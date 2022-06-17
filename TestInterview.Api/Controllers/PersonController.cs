using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestInterview.Api.Data;
using TestInterview.Api.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestInterview.Api.Controllers
{
   
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPerson _person;
        public PersonController(IPerson person)
        {
            _person = person;
        }
        // GET: api/<PersonController>
        [HttpGet]
        [Route("api/[controller]/[action]/id")]
        public IActionResult GetPersonById(int id)
        {
            var person = _person.GetById(id);
            if(person != null)
            {
                return Ok(person);
            }
            return NotFound();
        }

        // GET api/<PersonController>/5
        [HttpPost]
        [Route("api/[controller]/[action]")]
        public IActionResult AddPerson([FromBody] PersonModel model)
        {
            var persons = _person.Insert(model);
            if(persons != null)
            {
                return Ok(persons);
            }

            return BadRequest();
        }

        // POST api/<PersonController>
        [HttpGet]
        [Route("api/[controller]/[action]")]
        public IActionResult GetPersons()
        {
            var person = _person.ListPerson();
            if (person != null)
            {
                return Ok(person);
            }
            return BadRequest();
        }
    }
}
