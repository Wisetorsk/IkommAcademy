using Microsoft.AspNetCore.Mvc;
using WebApiDemo.Data;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiDemo.Controllers
{
    [ApiController]
    [Route("IKOMM/[controller]")]
    public class TestApiController : ControllerBase
    {
        
        public People People { get; set; }

        public TestApiController()
        {
            People = new People();
        }

        [HttpGet("{name}")]
        public IActionResult Get(string name) //Getting data from a dummy database
        {
            try
            {
                var person = People.Students.Where(m => m.FirstName.ToLower() == name.ToLower() 
                                                    || m.LastName.ToLower() == name.ToLower());
                if (!person.Any())
                {
                    throw new Exception($"Could not find person '{name}' in database");
                }
                return Ok(person);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
         
        }

        [HttpGet("{lastName}/{name}")]
        public IActionResult Get(string lastName, string name)
        {
            try
            {

                var person = People.Students.Where(m => m.FirstName.ToLower() == name.ToLower() 
                                                    && m.LastName.ToLower() == lastName.ToLower());
                if (!person.Any())
                {
                    throw new Exception($"Could not find person '{lastName} {name}' in database");
                }
                return Ok(person);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        public IActionResult Get()
        {
            var rng = new Random();
            return Ok(People.Students[rng.Next(People.Students.Count())]);
        }

        [HttpPost]
        public IActionResult Post([FromBody] TestPerson person)
        {
            Console.WriteLine($"I got this data:\n\n{person.ToString()}");
            Console.WriteLine(new string('*', Console.WindowWidth));
            return Created("", null);
        }
    }


}
