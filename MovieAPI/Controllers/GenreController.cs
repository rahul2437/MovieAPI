using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MovieAPI.Entities;
using MovieAPI.Filters;

namespace MovieAPI.Controllers
{
    [Route("api/genres")]
    [ApiController]
    public class GenreController : ControllerBase
    {
        private readonly ILogger<GenreController> logger;

        public GenreController(ILogger<GenreController> logger)
        {
            this.logger = logger;
        }
        [HttpGet]
        public async Task<ActionResult<List<Genre>>> Get()
        {
            logger.LogInformation("Getting all the genres");
            return new List<Genre>()
            {
                new Genre(){Id = 1,Name = "Comdey"}
            };
        }
        [HttpGet("{Id:int}")]
        public ActionResult<Genre> Get(int id)
        {
            throw new NotImplementedException();
        }
        [HttpPost]
        public ActionResult<Genre> Post([FromBody] Genre genre)
        {
            throw new NotImplementedException();
        }
        [HttpPut]
        public ActionResult<Genre> Put() 
        {
            throw new NotImplementedException();
        }
        [HttpDelete]
        public ActionResult<Genre> Delete() 
        {
            throw new NotImplementedException();
        }
    }
}
