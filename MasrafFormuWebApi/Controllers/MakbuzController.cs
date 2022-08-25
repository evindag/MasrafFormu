using Businnes.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MasrafFormuWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MakbuzController : Controller
    {
        private readonly IMakbuzService _makbuzService;
        public MakbuzController(IMakbuzService makbuzService)
        {
            _makbuzService = makbuzService;

        }
        [HttpPost("Add")]
        public IActionResult Add(Makbuz makbuz)
        {
            var result = _makbuzService.Add(makbuz);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
        [HttpGet("getall")]
        public List<Makbuz> GetList()
        {

            var result = _makbuzService.GetAll();
            return result;
        }
    }
}