using API.Models;
using API.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        private readonly PersonRepository personRepository;

        public PersonsController(PersonRepository personRepository)
        {
            this.personRepository = personRepository;
        }
        [HttpPost]
        public ActionResult Post(Person person)
        {
            var post = personRepository.Insert(person);
            if (post > 0)
            {
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }
        [HttpGet]
        public ActionResult Get()
        {
            var get = personRepository.Get();
            if (get != null)
            {
                return Ok(get);
            }
            else
            {
                return NotFound();
            }
           
        }
        [Route("{nik}")]
        public ActionResult Get(int nik)
        {
            var get = personRepository.Get(nik);
            if (get != null)
            {
                return Ok(get);
            }
            else
            {
                return NotFound();
            }
        }
        [HttpDelete("{nik}")]
        public ActionResult Delete(int nik)
        {
        var del = personRepository.Delete(nik);
            if (del == 1)
            {
                return Ok(del);
            }
            else
            {
                return BadRequest("salah NIK atau nik tidak ditemukan");
            }
        }
        [HttpPut]
        public ActionResult Put(Person person)
        {
            var get=personRepository.Update(person);
            if (get != null)
            {
                return Ok(get);
            }
            else
            {
                return NotFound();
            }
        }
    }
}
