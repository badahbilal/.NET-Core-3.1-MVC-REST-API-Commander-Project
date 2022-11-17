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

        public CommandsController(ICommanderRepo commanderRepo)
        {
            _commanderRepo = commanderRepo;
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

            return Ok(commandItem);
        }
    }
}
