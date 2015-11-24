using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace Husb.Community.EntityFramework.Repositories
{
    public abstract class CommunityRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<CommunityDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected CommunityRepositoryBase(IDbContextProvider<CommunityDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class CommunityRepositoryBase<TEntity> : CommunityRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected CommunityRepositoryBase(IDbContextProvider<CommunityDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
