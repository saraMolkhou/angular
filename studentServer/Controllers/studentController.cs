using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace studentServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class studentController : ControllerBase
    {
        private static  List<student> studentList= new List<student> {
            new student{ firstName= "neomi",lastName= "levi",grade= "A", city= "netanya" },
            new student{ firstName= "rehut",lastName= "choen",grade= "B",city= "rehovot"}
        };
        // GET: api/<studentController>
        [HttpGet]
        public IEnumerable<student> Get()
        {
            return studentList;
        }

        // GET api/<studentController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<studentController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<studentController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<studentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
