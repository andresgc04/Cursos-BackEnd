using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Persistencia;
using Dominio;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        //Realizando inyecciones de dependencias:
        private readonly CursosOnlineContext _context;

        public WeatherForecastController(CursosOnlineContext context){
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Curso> Get(){
            return _context.Curso.ToList();
        }
    }
}
