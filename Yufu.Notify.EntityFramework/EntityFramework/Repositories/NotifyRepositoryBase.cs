using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace Yufu.Notify.EntityFramework.Repositories
{
    public abstract class NotifyRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<NotifyDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected NotifyRepositoryBase(IDbContextProvider<NotifyDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class NotifyRepositoryBase<TEntity> : NotifyRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected NotifyRepositoryBase(IDbContextProvider<NotifyDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
