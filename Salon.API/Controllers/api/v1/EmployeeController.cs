using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Salon.Data.Repositories.Interfaces;

namespace Salon.API.Controllers.api.v1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IGiftCardRepository _giftCardRepository;
        public EmployeeController(IEmployeeRepository employeeRepository, IGiftCardRepository giftCardRepository)
        {
            _employeeRepository = employeeRepository;
            _giftCardRepository = giftCardRepository;
        }
        [Route("")]
        public IActionResult Get()
        {
            var employees = _employeeRepository.GetEmployees();
            return Ok(employees);
        }
        [Route("giftcards")]
        [HttpGet]
        public IActionResult GetGiftCards()
        {
            var giftCards = _giftCardRepository.GetAllGiftCards();
            return Ok(giftCards);
        }
    }
}