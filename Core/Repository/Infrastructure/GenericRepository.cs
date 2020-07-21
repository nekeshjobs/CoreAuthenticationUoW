using Entities.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Repository.Infrastructure
{
    public class GenericRepository<TEntity> where TEntity : class
    {
        private EmployeeDBContext EmployeeDBContext;
        private DbSet<TEntity> DBSet;

        public GenericRepository(EmployeeDBContext employeeDBContext)
        {
            EmployeeDBContext = employeeDBContext;
            DBSet = employeeDBContext.Set<TEntity>();
        }

        public virtual TEntity Get(Guid id)
        {
            return DBSet.Find(id);
        }

        public virtual IQueryable<TEntity> GetPredicate(Expression<Func<TEntity, bool>> predicate = null)
        {
            if (predicate != null)
            {
                return DBSet.AsNoTracking().Where(predicate);
            }

            return DBSet.AsNoTracking();
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return DBSet.ToList();
        }
    }
}
