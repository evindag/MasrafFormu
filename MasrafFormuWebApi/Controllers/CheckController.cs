using Business.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MasrafFormuWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CheckController : Controller
    {
        private readonly ICheckService _checkService;
        public CheckController(ICheckService checkService)
        {
            _checkService = checkService;

        }
        [HttpPost("Add")]
        public IActionResult Add(CheckDetailDto checkDto)
        {
            Check check = new Check { Address = checkDto.Address,CheckCost = checkDto.CheckCost,Company = checkDto.Company,
                Date = checkDto.Date,Description = checkDto.Description,Image = checkDto.Image,Person = checkDto.Person };
            var result = _checkService.Add(check);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
        [HttpGet("getall")]
        public IActionResult GetList()
        {

            var result = _checkService.GetAll();
            return Ok(result);
        }
    }
}