using AutoMapper;
using CasioCore.Services.Interfaces;
using DAL.Casino.Repositories.Interfaces;
using Models.Casino.DtoModels;
using Models.Casino.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasioCore.Services.Implementations
{
    public class ArticleService : IArticleService
    {
        private readonly IArticleRepository _articleRepository;
        private readonly IMapper _mapper;
        public ArticleService(IMapper mapper, IArticleRepository articleRepository)
        {
            _mapper = mapper;
            _articleRepository = articleRepository;
        }

        public IEnumerable<ArticleDto> GetAllArticles()
        {
            var items = _articleRepository.GetAll();
            var result = _mapper.Map<IEnumerable<ArticleDto>>(items);
            return result;
        }
    }
}
