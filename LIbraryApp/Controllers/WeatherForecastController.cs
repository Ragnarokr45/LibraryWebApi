using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LIbraryApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace LIbraryApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        LibraryContext context;
        public WeatherForecastController(LibraryContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public IEnumerable<Autor> Get()
        {
            using (context)
            {
                Autor autor = new Autor();
                autor.FirstName = "John";
                autor.SecondName = "Ivanov";
                context.Autors.Add(autor);
                context.SaveChanges();

                return context.Autors.ToList();
            }
        }
    }
}
