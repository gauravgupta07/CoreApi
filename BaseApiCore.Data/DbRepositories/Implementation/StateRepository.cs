using System;
using System.Collections.Generic;
using System.Text;
using BaseApiCore.Repository;
using BaseApiCore.Data.DbRepositories.Interfaces;

namespace BaseApiCore.Data.DbRepositories.Implementation
{
    public class StateRepository : Repository<State>, IStateRepository
    {
        public StateRepository(IDbContext dbContext) : base(dbContext)
        {
        }
    }
}
