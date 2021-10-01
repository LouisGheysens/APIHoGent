using APIHoGent.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIHoGent.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryXController : ControllerBase
    {
        private ICountryRepository repo;

        public CountryXController(ICountryRepository repo)
        {
            this.repo = repo;
        }


        //Get: api/Country/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            try
            {
                return Ok(repo.GetCountry(id));
            }catch(CountryException ex)
            {
                Response.StatusCode = 400;
                return NotFound();
            }
        }

        //Get: api/Country
        [HttpGet]
        [HttpHead]
        public IEnumerable<Country> GetAll([FromQuery] string continent)
        {
            if (!string.IsNullOrWhiteSpace(continent))
                return repo.GetAll(continent);
            else
                return repo.GetAll(continent);
        }

    }
}
