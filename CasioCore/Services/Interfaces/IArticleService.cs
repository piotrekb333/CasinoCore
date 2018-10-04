using Models.Casino.Entities;
using Models.Casino.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasioCore.Services.Interfaces
{
    public interface IArticleService
    {
        IEnumerable<ArticleDto> GetAllArticles();
    }
}
