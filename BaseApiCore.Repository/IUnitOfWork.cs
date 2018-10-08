using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaseApiCore.Repository
{
    public interface IUnitOfWork
    {
        IDbContext Context { get; }
        void Commit();
    }

}
