using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CitasClinica.Controllers.V1.Patient;
using CitasClinica.Repositories;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace CitasClinica.Controllers.V1.Doctor
{
    [ApiController]
    [Route("api/V1/[controller]")]
    [Tags("Doctors")]
    public class DoctorGetController : DoctorController
    {
        public DoctorGetController(IDoctorRepository _doctorRespository) : base(_doctorRespository)
        {
        }

        // Get all scheduled appointments for a doctor
        [HttpGet("{doctorId}/appointments")]
        [SwaggerOperation(
            Summary = "Get scheduled appointments for a doctor",
            Description = "Fetches all appointments for a specific doctor that are not cancelled, ordered by date."
        )]
        [SwaggerResponse(200, "List of scheduled appointments.")]
        [SwaggerResponse(400, "Invalid request data.")]
        [SwaggerResponse(404, "Doctor not found.")]
        public async Task<IActionResult> GetScheduledAppointments(int doctorId)
        {
            try
            {
                // Get scheduled appointments for the doctor
                var appointments = await doctorRepository.GetScheduledAppointmentsAsync(doctorId);

                // Return the appointments list with a 200 OK response
                return Ok(appointments);
            }
            catch (Exception ex)
            {
                // Return 400 Bad Request if there's an error
                return BadRequest(ex.Message);
            }
        }
    }
}