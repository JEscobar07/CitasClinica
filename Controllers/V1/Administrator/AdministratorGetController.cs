using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CitasClinica.Controllers.V1.Patient;
using CitasClinica.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace CitasClinica.Controllers.V1.Administrator
{
    [ApiController]
    [Route("api/V1/[controller]")]
    [Tags("Administrators")]
    public class AdministratorGetController : AdministratorController
    {
        public AdministratorGetController(IAdministratorRepository _administratorRepository) : base(_administratorRepository)
        {
        }

        // Endpoint to view medical availability of all doctors
        [HttpGet("availabilities")]
        [Authorize]
        [SwaggerOperation(
            Summary = "View medical availability of all doctors",
            Description = "This endpoint retrieves the available timeslots for all doctors. Only available time slots are returned, ordered by date and time."
        )]
        [SwaggerResponse(200, "List of available slots retrieved successfully.")]
        [SwaggerResponse(400, "Error retrieving availability data.")]
        public async Task<IActionResult> ViewMedicalAvailability()
        {
            try
            {
                // Fetch the list of available slots from the service
                var availabilities = await administratorRepository.ViewMedicalAvailabilityAsync();

                // Return the availability data with status 200 OK
                return Ok(availabilities);
            }
            catch (Exception ex)
            {
                // Return error status 400 if any issue occurs
                return BadRequest(ex.Message);
            }
        }
    }
}