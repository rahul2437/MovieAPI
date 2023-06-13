using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieAPI.Entities;
using MovieAPI.Filters;

namespace MovieAPI.Controllers
{
    [Route("api/genres")]
    [ApiController]
    public class GenreController : ControllerBase
    {
        private readonly ILogger<GenreController> logger;
        private readonly ApplicationDbContext context;

        public GenreController(ILogger<GenreController> logger, ApplicationDbContext context)
        {
            this.logger = logger;
            this.context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Genre>>> Get()
        {
            logger.LogInformation("Getting all the genres");
            return await context.Genres.ToListAsync();
        }
        [HttpGet("{Id:int}")]
        public ActionResult<Genre> Get(int id)
        {
            throw new NotImplementedException();
        }
        [HttpPost]
        public async Task<ActionResult<Genre>> Post([FromBody] Genre genre)
        {
            context.Genres.Add(genre);
            await context.SaveChangesAsync();
            return NoContent();
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
