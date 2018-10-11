using DAL.Casino.Context;
using DAL.Casino.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Casino.Repositories.Implementations
{
    public class CasinoRepository : RepositoryBase<Models.Casino.Entities.Casino>, ICasinoRepository
    {
        public CasinoRepository(WebApiContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
