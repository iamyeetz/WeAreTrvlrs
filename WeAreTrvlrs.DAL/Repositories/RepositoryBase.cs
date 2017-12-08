using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeAreTrvlrs.Contract.Repositories;
using WeAreTrvlrs.DAL.Data;


namespace WeAreTrvlrs.DAL.Repositories
{
   public class RepositoryBase <TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        internal DbContext dbContext;
        internal DbSet<TEntity> dbSet;

        public RepositoryBase(DataContext context)
        {
            this.dbContext = context;
            this.dbSet = context.Set<TEntity>();

        }

        public IQueryable GetAll()
        {
            return dbSet;
        }
    }
}
