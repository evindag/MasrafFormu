using Businnes.Abstract;
using Businnes.Concrete;
using DataAccess.Concrete.MongoDB;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MasrafFormuWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FisController : ControllerBase
    {
        private readonly IFisService _fisService;
        public FisController(IFisService fisService)
        {
            _fisService = fisService;

        }
        [HttpPost("Add")]
        public IActionResult Add(Fis fis)
        {
            var result = _fisService.Add(fis);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        //[HttpGet("Get")]
        //public string Get()
        //{
        //    IFisService fisService = new FisYonetimi(new MongoDB_FisDal());
        //    var result = fisService.GetAll();
        //    return result.Message;
        //}
        [HttpGet("GetAll")]
        public IActionResult Get()
        {
            var result = _fisService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("GetById")]
        public IActionResult Get(int id)
        {
            var result= _fisService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

           
        

    }
}
