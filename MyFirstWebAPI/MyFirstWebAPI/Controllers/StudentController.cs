using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyFirstWebAPI.Services;

namespace MyFirstWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _service;
        public StudentController(IStudentService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetStudents()
        {
            return Ok(_service.GetStudents());
        }

        //public IActionResult GetStudents()
        //{
        //    var student = new[]
        //    {
        //        new {Id=1,Name="Sagar" },
        //        new{ Id=2,Name="Rahul"}
        //    };
        //    return Ok(student);
        //}
    }
}
