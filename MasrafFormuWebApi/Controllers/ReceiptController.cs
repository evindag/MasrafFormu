using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.MongoDB;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MasrafFormuWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReceiptController : ControllerBase
    {
        private readonly IReceiptService _receiptService;
        public ReceiptController(IReceiptService receiptService)
        {
            _receiptService = receiptService;

        }
        [HttpPost("Add")]
        public IActionResult Add(ReceiptDetailDto receipt)
        {
            Receipt receipt1 = new Receipt { Company = receipt.Company, Date = receipt.Date, 
                Description = receipt.Description, Image = receipt.Image, Person = receipt.Person,
                ReceiptNo = receipt.ReceiptNo,ReceiptType = receipt.ReceiptType,TotalCost = receipt.TotalCost,Vat = receipt.Vat };
            var result = _receiptService.Add(receipt1);
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
            var result = _receiptService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("GetById")]
        public IActionResult Get(string id)
        {
            var result= _receiptService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

           
        

    }
}
