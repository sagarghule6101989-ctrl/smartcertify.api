using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyFirstWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        public IActionResult GetStudents()
        {
            var student = new[]
            {
                new {Id=1,Name="Sagar" },
                new{ Id=2,Name="Rahul"}
            };
            return Ok(student);
        }
    }
}
