using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess.EntityFramework
{
    public class EfUserRepositoryBase<TUser, TContext> : IUserRepository<TUser>
        where TUser : class, IUsers, new()
        where TContext : DbContext, new()
    {
        public void Add(TUser user)
        {
            using (TContext context = new TContext())
            {
                var addedUser = context.Entry(user);
                addedUser.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(TUser user)
        {
            using (TContext context = new TContext())
            {
                var deletedUser = context.Entry(user);
                deletedUser.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public TUser Get(Expression<Func<TUser, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TUser>().SingleOrDefault(filter);
            }
        }

        public List<TUser> GetAll(Expression<Func<TUser, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null ? context.Set<TUser>().ToList() :
                    context.Set<TUser>().Where(filter).ToList();
            }
        }

        public void Update(TUser user)
        {
            using (TContext context = new TContext())
            {
                var updatedUser = context.Entry(user);
                updatedUser.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
