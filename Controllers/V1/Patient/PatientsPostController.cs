using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CitasClinica.DTOS;
using CitasClinica.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CitasClinica.Controllers.V1.Patient
{
    [ApiController]
    [Route("api/V1/[controller]")]
    [Tags("Patients")]
    public class PatientsPostController : PatientsController
    {
        public PatientsPostController(IPatientRepository _patientRespository) : base(_patientRespository)
        {
        }

        // Request appointment
        [HttpPost("{patientId}/appointments")]
        public async Task<IActionResult> RequestAppointment(int patientId, [FromBody] AppointmentDTO appointmentRequest)
        {
            try
            {
                var appointment = await patientRepository.RequestAppointmentAsync(patientId, appointmentRequest);
                return Ok(appointment);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}