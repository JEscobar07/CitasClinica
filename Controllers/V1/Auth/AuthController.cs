using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CitasClinica.Config;
using CitasClinica.Data;
using CitasClinica.DTOS;
using CitasClinica.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Swashbuckle.AspNetCore.Annotations;

namespace CitasClinica.Controllers.V1.Auth
{
    [ApiController]
    [Route("api/v1/[controller]")]
    [Tags("Auth")]
    public class AuthController : ControllerBase
    {
        private readonly AppDbContext appDbContext;
        private readonly Utilities utilities;
        public AuthController(AppDbContext _appDbContext, Utilities _utilities)
        {
            appDbContext = _appDbContext;
            utilities = _utilities;
        }

        // Register a new administrator
        [HttpPost("Register")]
        [SwaggerOperation(
            Summary = "Register a new administrator",
            Description = "Allows an administrator to register by providing an email and a password. The password is encrypted before storing."
        )]
        [SwaggerResponse(400, "Invalid request data.")]
        [SwaggerResponse(201, "Administrator registered successfully.")]
        public async Task<ActionResult<Models.Administrator>> PostRegister([FromBody] AdministratorDTO administratorDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState); // Return 400 Bad Request if model state is invalid
            }
            else
            {
                // Encrypt the password before storing it
                var user = new Models.Administrator
                {
                    Email = administratorDTO.Email,
                    Password = utilities.EncryptSHA256(administratorDTO.Password)
                };

                // Add the new administrator to the database
                await appDbContext.Administrators.AddAsync(user);
                await appDbContext.SaveChangesAsync();

                // Return the newly created administrator details
                return CreatedAtAction(nameof(PostRegister), new { id = user.Id }, user); // 201 Created with location header
            }
        }

        // Login an administrator and generate a JWT token
        [HttpPost("Login")]
        [SwaggerOperation(
            Summary = "Login an administrator",
            Description = "Authenticates an administrator by email and password and returns a JWT token if successful."
        )]
        [SwaggerResponse(400, "Invalid request data.")]
        [SwaggerResponse(401, "Unauthorized: Invalid email or password.")]
        [SwaggerResponse(200, "Login successful, JWT token generated.")]
        public async Task<ActionResult> PostLogin([FromBody] AdministratorDTO administratorDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState); // Return 400 Bad Request if model state is invalid
            }
            else
            {
                var userFound = await appDbContext.Administrators
                    .FirstOrDefaultAsync(i => i.Email == administratorDTO.Email);

                if (userFound == null)
                {
                    return Unauthorized("Invalid email."); // Return 401 Unauthorized if email doesn't match
                }

                var passwordValid = userFound.Password == utilities.EncryptSHA256(administratorDTO.Password);

                if (!passwordValid)
                {
                    return Unauthorized("Invalid password."); // Return 401 Unauthorized if password doesn't match
                }

                // Generate JWT token upon successful login
                var token = utilities.GenerateJwtToken(userFound);

                // Return the token with a success message
                return Ok(new { message = "Save this token", jwt = token });
            }
        }
    }
}