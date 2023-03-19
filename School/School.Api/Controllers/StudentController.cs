using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
//using School.API.Models;
using School.Infrastructure.BusinessObjects;
//using School.Infrastructure.Models;
using School.Infrastructure.Services;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace School.Api.Controllers
{
    [ApiController]

    [Route("v1/[controller]")]
    //[EnableCors("AllowSites")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }
        // GET: api/<StudentController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<StudentController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<StudentController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<StudentController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<StudentController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            _studentService.DeleteStudent(id);
            return Ok();
        }
    }
}
