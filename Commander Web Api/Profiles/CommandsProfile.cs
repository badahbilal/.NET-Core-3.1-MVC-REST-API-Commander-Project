using AutoMapper;
using Commander_Web_Api.Dtos;
using Commander_Web_Api.Models;

namespace Commander_Web_Api.Profiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {

            // Source ===> Target

            CreateMap<Command, CommandReadDto>();

            CreateMap<CommandCreateDto, Command>();

            CreateMap<CommandUpdateDto, Command>();


        }
    }
}
