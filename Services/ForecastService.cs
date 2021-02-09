using Projeto.Context;
using System.Collections.Generic;
using System.Linq;

namespace Projeto.Services
{
    public class ForecastService
    {
        private TodoContext Context {get;}

        public ForecastService(TodoContext context){
            Context = context;
        }

        public IEnumerable<Forecast> GetAll ()
        {
            return Context.Forecasts;

        }

        public Forecast? GetById(int id){
            return Context.Forecasts.FirstOrDefault(forecast=> forecast.Id == id);            
        }

    }
}

