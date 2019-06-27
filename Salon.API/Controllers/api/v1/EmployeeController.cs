using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Salon.Data.Repositories.Interfaces;
using Salon.Service.Interfaces;

namespace Salon.API.Controllers.api.v1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IGiftCardService _giftCardService;
        public EmployeeController(IEmployeeRepository employeeRepository, IGiftCardService giftCardService)
        {
            _employeeRepository = employeeRepository;
            _giftCardService = giftCardService;
        }
        [Route("")]
        public IActionResult Get()
        {
            var employees = _employeeRepository.GetEmployees();
            return Ok(employees);
        }
       
    }
}