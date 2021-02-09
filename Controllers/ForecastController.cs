using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Projeto.Services;

namespace Projeto.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ForecastController : ControllerBase
    {

        private readonly ILogger<ForecastController> _logger;
        private ForecastService ForecastService{get;}

        public ForecastController(ILogger<ForecastController> logger, ForecastService forecastService)
        {
            _logger = logger;
            ForecastService = forecastService;

        }
        
        
        [HttpGet]
        public IEnumerable<Forecast> Get()
        {
            return ForecastService.GetAll();
        }

        [HttpGet("{id}")]
        public ActionResult GetById([FromRoute] int id){
            var forecast = ForecastService.GetById(id);
            
            if(forecast is null){
                var value = new { Message = "Nenhum forecast com esse id." };

                return new NotFoundObjectResult(value);
            }

            return Ok(forecast);
        }
    }
}

