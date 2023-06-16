using MovieAPI.DTOs;

namespace MovieAPI
{
    public class FilterMoviesDTO
    {
        public int Page { get; set; } = 1;
        public int RecordsPerPage { get; set; } = 10;
        public PaginationDTO? paginationDTO 
        { get
            {
                return new PaginationDTO()
                {
                    Page = Page,
                    RecordsPerPage = RecordsPerPage,
                };
            } 
        }
        public string? Title { get; set; }
        public int GenreId { get; set; } = 0;
        public bool InTheaters { get; set; }
        public bool UpComingReleases { get; set; }
    }
}
