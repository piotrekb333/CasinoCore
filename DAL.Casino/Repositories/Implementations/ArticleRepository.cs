using DAL.Casino.Context;
using DAL.Casino.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Casino.Repositories.Implementations
{
    public class ArticleRepository : RepositoryBase<ArticleRepository>, IArticleRepository
    {
        public ArticleRepository(WebApiContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
