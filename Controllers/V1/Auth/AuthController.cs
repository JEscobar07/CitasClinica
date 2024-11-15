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

        [HttpPost("Register")]
        public async Task<ActionResult<Administrator>> PostRegister([FromBody] AdministratorDTO administratorDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                var user = new Administrator
                {
                    Email = administratorDTO.Email,
                    Password = utilities.EncryptSHA256(administratorDTO.Password)
                };
                await appDbContext.Administrators.AddAsync(user);
                await appDbContext.SaveChangesAsync();
                return Ok(user);
            }
        }

        [HttpPost("Login")]
        public async Task<ActionResult> PostLogin([FromBody] AdministratorDTO administratorDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                var userFound = await appDbContext.Administrators.FirstOrDefaultAsync(i => i.Email == administratorDTO.Email);
                if (userFound == null)
                {
                    return Unauthorized("Email invalido");
                }

                var passwordvalid = userFound.Password == utilities.EncryptSHA256(administratorDTO.Password);

                if (passwordvalid == false)
                {
                    return Unauthorized("Password invalida");
                }
                //Here we call the method to create the jwt
                var token = utilities.GenerateJwtToken(userFound);

                // Here the token can be sent with a dictionary to accompany it with a message example: Ok( new{ message = “Save this token”, jwt = token})
                return Ok(new { message = "Guardar este token", jwt = token });
            }
        }
    }
}