using AutoMapper;
using MinimalAPI.Dtos;
using MinimalAPI.Models;

namespace MinimalAPI
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
            // Source -> Target
            CreateMap<Command, CommandReadDto>().ReverseMap();
            CreateMap<Command, CommandCreateDto>().ReverseMap();
            CreateMap<Command, CommandUpdateDto>().ReverseMap();
        }
    }
}

