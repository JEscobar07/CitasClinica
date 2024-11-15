using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CitasClinica.Controllers.V1.Patient;
using CitasClinica.DTOS;
using CitasClinica.Repositories;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace CitasClinica.Controllers.V1.Doctor
{
    [ApiController]
    [Route("api/V1/[controller]")]
    [Tags("Doctors")]
    public class DoctorPostController : DoctorController
    {
        public DoctorPostController(IDoctorRepository _doctorRespository) : base(_doctorRespository)
        {
        }

        // Register a doctor's availability
        [HttpPost("{doctorId}/availabilities")]
        [SwaggerOperation(
            Summary = "Register a doctor's availability",
            Description = "Allows a doctor to register a new available time slot."
        )]
        [SwaggerResponse(201, "Availability registered successfully.")]
        [SwaggerResponse(400, "Invalid request data.")]
        [SwaggerResponse(404, "Doctor not found.")]
        public async Task<IActionResult> RegisterAvailability(int doctorId, [FromBody] AvailabilityDTO availabilityRequest)
        {
            try
            {
                // Register the doctor's availability
                var availability = await doctorRepository.RegisterAvailabilityAsync(doctorId, availabilityRequest);

                // Return 201 Created with the newly created availability details
                return CreatedAtAction(nameof(RegisterAvailability), new { doctorId = doctorId, id = availability.Id }, availability);
            }
            catch (Exception ex)
            {
                // Return 400 Bad Request if there is an error
                return BadRequest(ex.Message);
            }
        }
    }
}