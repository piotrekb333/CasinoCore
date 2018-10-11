using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CasioCore.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CasioCore.Controllers
{
    [Produces("application/json")]
    public class CasinosController : ControllerBase
    {
        private readonly ICasinoService _casinoService = null;
        private readonly IMapper _mapper = null;
        public CasinosController(IMapper mapper, ICasinoService casinoService)
        {
            _mapper = mapper;
            _casinoService = casinoService;
        }

    }
}
