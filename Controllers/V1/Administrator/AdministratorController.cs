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
    [Tags("Administrators")]
    public class AdministratorController: ControllerBase
    {
        protected readonly IAdministratorRepository administratorRepository;
        public AdministratorController(IAdministratorRepository _administratorRepository)
        {
            administratorRepository = _administratorRepository;
        }
    }
}