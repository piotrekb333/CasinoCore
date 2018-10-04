using DAL.Casino.Context;
using DAL.Casino.Repositories.Interfaces;
using Models.Casino.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DAL.Casino.Repositories.Implementations
{
    public class ArticleRepository : RepositoryBase<Article>, IArticleRepository
    {
        public ArticleRepository(WebApiContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
