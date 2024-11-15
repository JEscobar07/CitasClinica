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
    public class DoctorPutController : DoctorController
    {
        public DoctorPutController(IDoctorRepository _doctorRespository) : base(_doctorRespository)
        {
        }

        // Update the status of a specific appointment
        [HttpPut("{doctorId}/appointments/{appointmentId}/status")]
        [SwaggerOperation(
            Summary = "Update the status of an appointment",
            Description = "This endpoint allows updating the status of a specific appointment for a doctor."
        )]
        [SwaggerResponse(200, "Appointment status updated successfully.")]
        [SwaggerResponse(400, "Invalid request data.")]
        [SwaggerResponse(404, "Appointment not found.")]
        public async Task<IActionResult> UpdateAppointmentStatus(int doctorId, int appointmentId, [FromBody] string status)
        {
            try
            {
                // Attempt to update the appointment status
                var result = await doctorRepository.UpdateAppointmentStatusAsync(doctorId, appointmentId, status);

                // If update is successful, return 200 OK
                return result ? Ok("Appointment status updated successfully.") : NotFound("Appointment not found.");
            }
            catch (Exception ex)
            {
                // Return 400 Bad Request if an error occurs
                return BadRequest(ex.Message);
            }
        }
    }
}