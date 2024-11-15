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
    public class PatientsController : ControllerBase
    {
        protected readonly IPatientRepository patientRepository;
        public PatientsController(IPatientRepository _patientRespository)
        {
            patientRepository = _patientRespository;
        }
    }
}