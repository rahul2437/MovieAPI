using AutoMapper;
using MovieAPI.DTOs;
using MovieAPI.Entities;

namespace MovieAPI.Helpers
{
    public class AutoMapperProfiles:Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<GenreDTO, Genre>().ReverseMap();
            CreateMap<GenreCreationDTO, Genre>();

            CreateMap<ActorDTO, Actor>().ReverseMap();
            CreateMap<ActorCreationDTO, Actor>().ForMember(x=>x.Picture,options=>options.Ignore());

        }
    }
}
