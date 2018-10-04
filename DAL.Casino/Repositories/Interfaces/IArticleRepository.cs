using Models.Casino.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DAL.Casino.Repositories.Interfaces
{
    public interface IArticleRepository
    {
        IEnumerable<Article> GetAll();
        IEnumerable<Article> GetByCondition(Expression<Func<Article, bool>> expression);
        Article GetById(int id);
        void Create(Article entity);
        void Update(Article entity);
        void Delete(Article entity);
        void Save();
    }
}
