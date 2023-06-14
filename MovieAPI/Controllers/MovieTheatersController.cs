using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieAPI.DTOs;
using MovieAPI.Entities;
using MovieAPI.Helpers;

namespace MovieAPI.Controllers
{
    [ApiController]
    [Route("api/movietheaters")]
    public class MovieTheatersController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public MovieTheatersController(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        [HttpGet]
        public async Task<ActionResult<List<MovieTheaterDTO>>> Get([FromQuery] PaginationDTO paginationDTO)
        {
            var queryable = context.MoviesTheaters.AsQueryable();

            await HttpContext.InsertParametersPaginationInHeaders(queryable);

            var movieTheaters = await queryable.OrderBy(x => x.Name).Paginate(paginationDTO).ToListAsync();

            return mapper.Map<List<MovieTheaterDTO>>(movieTheaters);
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<MovieTheaterDTO>> Get(int id)
        {
            var movieTheater = await context.MoviesTheaters.FirstOrDefaultAsync(x => x.Id == id);
            if(movieTheater == null)
            {
                return NotFound();
            }
            return mapper.Map<MovieTheaterDTO>(movieTheater);
        }
        [HttpPost]
        public async Task<ActionResult> Post(MovieTheaterCreationDTO movieTheaterCreationDTO)
        {
            var movieTheater = mapper.Map<MovieTheater>(movieTheaterCreationDTO);
            context.Add(movieTheater);
            await context.SaveChangesAsync();
            return NoContent();
        }
        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(int id,MovieTheaterCreationDTO movieTheaterCreationDTO)
        {
            var movieTheater = await context.MoviesTheaters.FirstOrDefaultAsync(x => x.Id == id);
            if (movieTheater == null)
            {
                return NotFound();
            }
            movieTheater = mapper.Map(movieTheaterCreationDTO, movieTheater);
            await context.SaveChangesAsync();
            return NoContent();
        }
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var movieTheater = await context.MoviesTheaters.AnyAsync(x => x.Id == id);
            if (!movieTheater)
            {
                return NotFound();
            }
            context.Remove(movieTheater);
            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}
