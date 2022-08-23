using Businnes.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace MasrafFormuWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FisController : Controller
    {
        private readonly IFisService _fisService;
        public FisController(IFisService fisService)
        {
            _fisService = fisService;
                
        }
        [HttpPost("Add")]
        public IActionResult Add(Fis fis)
        {
           var result =  _fisService.Add(fis);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
    }
}
