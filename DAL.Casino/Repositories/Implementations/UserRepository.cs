using DAL.Casino.Context;
using DAL.Casino.Repositories.Interfaces;
using Models.Casino.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Casino.Repositories.Implementations
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(WebApiContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
