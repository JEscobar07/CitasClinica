using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CitasClinica.Models;
using CitasClinica.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

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


        [HttpGet("{patientId}/appointments/history")]
        [SwaggerOperation(
            Summary = "Get appointment history",
            Description = "Retrieves the appointment history for a specified patient."
        )]
        [SwaggerResponse(400, "Invalid model.")]
        [SwaggerResponse(404, "No appointments found for this patient.")]
        [SwaggerResponse(200, "Appointment history retrieved successfully.")]
        public async Task<IActionResult> GetAppointmentHistory(int patientId)
        {
            var appointments = await patientRepository.GetAppointmentHistoryAsync(patientId);
            if (appointments == null || !appointments.Any())
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