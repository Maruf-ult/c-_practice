using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NZWalks.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllStudents()
        {
            var students = new List<string>
            {
                "John Doe",
                "Jane Smith",
                "Alice Johnson",
                "Bob Brown"
            };
            return Ok(students);
        }
    }
}
