using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace Husb.ZeroDemo.EntityFramework.Repositories
{
    public abstract class ZeroDemoRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<ZeroDemoDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected ZeroDemoRepositoryBase(IDbContextProvider<ZeroDemoDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class ZeroDemoRepositoryBase<TEntity> : ZeroDemoRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected ZeroDemoRepositoryBase(IDbContextProvider<ZeroDemoDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
