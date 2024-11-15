using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CitasClinica.Repositories;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace CitasClinica.Controllers.V1.Patient
{
    [ApiController]
    [Route("api/V1/[controller]")]
    [Tags("Patients")]
    public class PatientsDeleteController : PatientsController
    {
        public PatientsDeleteController(IPatientRepository _patientRespository) : base(_patientRespository)
        {
        }

        // Cancel an appointment
        [HttpDelete("{patientId}/appointments/{appointmentId}")]
        [SwaggerOperation(
            Summary = "Cancel an appointment",
            Description = "Cancels a specific appointment for a patient."
        )]
        [SwaggerResponse(400, "Invalid request.")]
        [SwaggerResponse(404, "Appointment not found.")]
        [SwaggerResponse(200, "Appointment cancelled successfully.")]
        public async Task<IActionResult> CancelAppointment(int patientId, int appointmentId)
        {
            try
            {
                var result = await patientRepository.CancelAppointmentAsync(patientId, appointmentId);
                return result ? Ok("Appointment cancelled successfully.") : NotFound("Appointment not found.");
            }
            catch (Exception ex)
            {
                // This handles the case where the appointment is not found in the service layer
                return NotFound(ex.Message);
            }
        }

    }
}