using AutoMapper;
using CommanderAPI.Data;
using CommanderAPI.Data_Transfer_Object;
using CommanderAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommanderAPI.Controllers
{
    //api/commands
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        //private readonly MockCommanderRepo _repository = new MockCommanderRepo();
        private readonly ICommanderRepo _repository;
        private readonly IMapper _mapper;
        public CommandsController(ICommanderRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        [HttpGet]
        public ActionResult <IEnumerable<Command>> GetAll()
        {
            var commandItems = _repository.GetAppCommands();

            return Ok(_mapper.Map<IEnumerable<CommandReadDto>>(commandItems));
        }
        //GET api/commands/id
        [HttpGet("{id}",Name ="GetByID")]
        public ActionResult <CommandReadDto> GetByID(int id)
        {
            var commandItem = _repository.GetCommandByID(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<CommandReadDto>(commandItem));
            }
            return NotFound();
        }

        //POST api/commands

        [HttpPost]
        public ActionResult <CommandReadDto> CreateCommand(CommandsCreateDto commandCreate)
        {
            var commandModel = _mapper.Map<Command>(commandCreate);

            _repository.CreateCommand(commandModel);
            _repository.SaveChanges();
            var commandReadDto = _mapper.Map<CommandReadDto>(commandModel);
            return CreatedAtRoute(nameof(GetByID), new {id = commandReadDto.id }, commandReadDto);
        }

        //PUT api/commands/{id}

        [HttpPut("{id}")]
        public ActionResult UpdateCommand(int id, CommandUpdateDTO commandobject)
        {
            var commandFromRepo = _repository.GetCommandByID(id);
            if(commandFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(commandobject, commandFromRepo);

            _repository.updateCommand(commandFromRepo);

            _repository.SaveChanges();

            return NoContent();
        }



    }
}
