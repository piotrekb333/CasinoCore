using AutoMapper;
using CasioCore.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasioCore.Services.Implementations
{
    public class CasinoService : ICasinoService
    {
        private readonly ICasinoService _casinoService;
        private readonly IMapper _mapper;
        public CasinoService(IMapper mapper, ICasinoService casinoService)
        {
            _mapper = mapper;
            _casinoService = casinoService;
        }
    }
}
