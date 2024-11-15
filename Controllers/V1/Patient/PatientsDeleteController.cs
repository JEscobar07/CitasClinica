using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CitasClinica.Repositories;
using Microsoft.AspNetCore.Mvc;

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

        // Cancel appointment
        [HttpDelete("{patientId}/appointments/{appointmentId}")]
        public async Task<IActionResult> CancelAppointment(int patientId, int appointmentId)
        {
            var result = await patientRepository.CancelAppointmentAsync(patientId, appointmentId);
                return result ? Ok("Appointment cancelled successfully.") : NotFound("Appointment not found.");
        }
    }
}