using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CitasClinica.Controllers.V1.Patient;
using CitasClinica.DTOS;
using CitasClinica.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace CitasClinica.Controllers.V1.Administrator
{
    [ApiController]
    [Route("api/V1/[controller]")]
    [Tags("Administrators")]
    public class AdministratorPutController : AdministratorController
    {
        public AdministratorPutController(IAdministratorRepository _administratorRepository) : base(_administratorRepository)
        {
        }

        // Endpoint to reschedule an appointment
        [HttpPut("appointments/{appointmentId}/reschedule")]
        [Authorize]
        [SwaggerOperation(
            Summary = "Reschedule an existing appointment",
            Description = "This endpoint allows the rescheduling of an existing appointment to a new date and time."
        )]
        [SwaggerResponse(200, "Appointment successfully rescheduled.")]
        [SwaggerResponse(400, "Invalid request data.")]
        [SwaggerResponse(404, "Appointment or availability not found.")]
        public async Task<IActionResult> RescheduleAppointment(int appointmentId, [FromBody] AppointmentRescheduleDTO rescheduleRequest)
        {
            try
            {
                // Attempt to reschedule the appointment
                var appointment = await administratorRepository.RescheduleAppointmentAsync(appointmentId, rescheduleRequest);

                // If rescheduling is successful, return the updated appointment
                return Ok(appointment);
            }
            catch (Exception ex)
            {
                // Return 400 Bad Request if any error occurs (e.g., invalid data)
                return BadRequest(ex.Message);
            }
        }
    }
}