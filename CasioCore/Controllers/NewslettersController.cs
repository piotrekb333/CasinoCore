using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CasioCore.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Models.Casino.DtoModels;


namespace CasioCore.Controllers
{
    [Produces("application/json")]
    public class NewslettersController : ControllerBase
    {
        private readonly INewsletterService _newsletterService = null;
        private readonly IMapper _mapper = null;
        public NewslettersController(IMapper mapper, INewsletterService newsletterService)
        {
            _mapper = mapper;
            _newsletterService = newsletterService;
        }

        [HttpPost]
        [Route("api/Messages/SendMessage")]
        public IActionResult Subscribe(NewsletterDto model)
        {
            _newsletterService.Subscribe(model);
            return Ok();
        }
    }
}
