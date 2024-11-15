using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CitasClinica.DTOS;
using CitasClinica.Repositories;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

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

        // Request an appointment
        [HttpPost("{patientId}/appointments")]
        [SwaggerOperation(
            Summary = "Request an appointment",
            Description = "Allows a patient to request an appointment with a specified doctor at a given time."
        )]
        [SwaggerResponse(400, "Invalid request data.")]
        [SwaggerResponse(404, "Patient or availability not found.")]
        [SwaggerResponse(201, "Appointment successfully created.")]
        public async Task<IActionResult> RequestAppointment(int patientId, [FromBody] AppointmentDTO appointmentRequest)
        {
            try
            {
                var appointment = await patientRepository.RequestAppointmentAsync(patientId, appointmentRequest);
                return CreatedAtAction(nameof(RequestAppointment), new { id = appointment.Id }, appointment); // Return 201 Created with appointment details
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message); // Return 400 Bad Request if there's an error
            }
        }
    }
}