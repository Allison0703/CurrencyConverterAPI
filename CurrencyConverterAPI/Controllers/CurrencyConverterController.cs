using Microsoft.AspNetCore.Mvc;
using System;
using CurrencyConverterAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CurrencyConverterAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurrencyConverterController : ControllerBase
    {
        // GET: api/<CurrencyConverterController>
        [HttpGet]
        public IActionResult Get(string source, string target, string amount)
        {
            try
            {
                Services services = new Services();
                ConverterResult result = new ConverterResult("success", services.CurrencyConvert(source, target, amount));
                return Ok(result);
            }
            catch(Exception ex)
            {
                return BadRequest(new ConverterResult(ex.Message, 0));
            }
        }
    }
}
