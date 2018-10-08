using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CasioCore.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Models.Casino.DtoModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CasioCore.Controllers
{
    [Produces("application/json")]
    public class MessagesController : ControllerBase
    {
        private readonly IMessageService _messageService = null;
        private readonly IMapper _mapper = null;
        public MessagesController(IMapper mapper, IMessageService messageService)
        {
            _mapper = mapper;
            _messageService = messageService;
        }

        [HttpPost]
        [Route("api/Messages/SendMessage")]
        public IActionResult SendMessage(MessageDto model)
        {
            _messageService.SendMessage(model);
            return Ok();
        }
    }
}
