using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CitasClinica.Models;
using CitasClinica.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CitasClinica.Controllers.V1.Patient
{
    [ApiController]
    [Route("api/V1/[controller]")]
    [Tags("Patients")]
    public class PatientsGetController : PatientsController
    {
        public PatientsGetController(IPatientRepository _patientRespository) : base(_patientRespository)
        {
        }

        // Get appointment history
        [HttpGet("{patientId}/appointments/history")]
        public async Task<IActionResult> GetAppointmentHistory(int patientId)
        {
            var appointments = await patientRepository.GetAppointmentHistoryAsync(patientId);
            if (appointments == null)
            {
                return NotFound("No appointments found for this patient.");
            }
            else
            {
                return Ok(appointments);
            }
        }
    }
}