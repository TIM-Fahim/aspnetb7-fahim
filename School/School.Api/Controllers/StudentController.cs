using Autofac;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using School.Api.DTOs;
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
        //private readonly IStudentService _studentService;
        private readonly ILifetimeScope _scope;
        private readonly ILogger<StudentController> _logger;
        public StudentController(ILifetimeScope scope, ILogger<StudentController> logger)
        {
            _scope = scope;
            _logger = logger;
        }
        // GET: api/<StudentController>
        [HttpGet]
        public async Task<ActionResult<object>> Get()
        {
            StudentDTO studentDTOs = _scope.Resolve<StudentDTO>();
            var result = await studentDTOs.GetAllStudentAsync();
            return Ok(result);
        }

        // GET api/<StudentController>/5
        [HttpGet("{id}")]
        public string Get(Guid id)
        {
            return "value";
        }

        // POST api/<StudentController>
        [HttpPost]
       /* public void Post([FromBody] string value)
        {

        }*/
        public IActionResult Post(StudentDTO studentDTO)
        {
            try
            {
                studentDTO.ResolveDependency(_scope);
                studentDTO.CreateStudent();
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Couldn't create student");
                return BadRequest();
            }
        }

        // PUT api/<StudentController>/5
        [HttpPut] //("{id}")
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        public IActionResult Put(StudentDTO model)
        {
            try
            {
                model.ResolveDependency(_scope);
                model.UpdateStudent();

                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Couldn't delete course");
                return BadRequest();
            }
        }

        // DELETE api/<StudentController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            //_studentService.DeleteStudent(id);
            //return Ok();
            try
            {
                StudentDTO studentDTO = _scope.Resolve<StudentDTO>();
                studentDTO.DeleteStudent(id);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error deleting student");
                return BadRequest();
            }
        }
    }
}
