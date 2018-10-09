using AutoMapper;
using Models.Casino.DtoModels;
using Models.Casino.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasioCore.Configuration
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Article, ArticleDto>();
            CreateMap<ArticleDto, Article>();

            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();

            CreateMap<Newsletter, NewsletterDto>();
            CreateMap<NewsletterDto, Newsletter>();
        }
    }
}
