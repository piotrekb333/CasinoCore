using AutoMapper;
using CasioCore.Services.Interfaces;
using DAL.Casino.Repositories.Interfaces;
using Models.Casino.DtoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasioCore.Services.Implementations
{
    public class NewsletterService : INewsletterService
    {
        private readonly INewsletterRepository _newsletterRepository;
        private readonly IMapper _mapper;
        public NewsletterService(IMapper mapper, INewsletterRepository newsletterRepository)
        {
            _mapper = mapper;
            _newsletterRepository = newsletterRepository;
        }

        public bool Subscribe(NewsletterDto model)
        {
            _newsletterRepository.Create(new Models.Casino.Entities.Newsletter
            {
                CreatedDate = DateTime.UtcNow,
                Email = model.Email
            });
            return true;
        }
    }
}
