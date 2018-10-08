using System;
using System.Collections.Generic;
using System.Text;
using BaseApiCore.Repository;
using Microsoft.EntityFrameworkCore;

namespace BaseApiCore.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        public IDbContext Context { get; }

        public UnitOfWork(IDbContext context)
        {
            Context = context;
        }

        public void Commit()
        {
            Context.SaveChanges();
        }

        public void Dispose()
        {
            Context.Dispose();

        }       
    }
}
