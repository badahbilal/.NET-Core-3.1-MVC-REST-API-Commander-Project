using AutoMapper;
using Commander_Web_Api.Data;
using Commander_Web_Api.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;

namespace Commander_Web_Api.Controllers
{
    //api/commands
    [Route("api/[controller]")]
    [ApiController]
    public class CommandsController : ControllerBase
    {

        private readonly ICommanderRepo _commanderRepo;
        private readonly IMapper _mapper;

        public CommandsController(ICommanderRepo commanderRepo, IMapper mapper)
        {
            _commanderRepo = commanderRepo;
            _mapper = mapper;

        }

        //GET api/commands
        [HttpGet]
        public ActionResult <IEnumerable<Command>> GetallCommands()
        {
            var commandItems =  _commanderRepo.GetAllCommands();

            return Ok(commandItems);

        }


        //GET this method should response for api/commands/5
        [HttpGet("{id}")]
        public ActionResult <Command> GetCommandById(int id)
        {
            var commandItem = _commanderRepo.GetCommandById(id);

            if (commandItem == null)
            {
                return NotFound();
            }
            return Ok(commandItem);

        }
    }
}
