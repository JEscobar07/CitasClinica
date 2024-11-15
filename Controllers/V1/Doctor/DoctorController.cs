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
    [Tags("Doctors")]
    public class DoctorController: ControllerBase
    {
        protected readonly IDoctorRepository doctorRepository;
        public DoctorController(IDoctorRepository _doctorRespository)
        {
            doctorRepository = _doctorRespository;
        }
    }
}