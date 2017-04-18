using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace SuperRocket.OrchardCore.EntityFramework.Repositories
{
    public abstract class OrchardCoreRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<OrchardCoreDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected OrchardCoreRepositoryBase(IDbContextProvider<OrchardCoreDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class OrchardCoreRepositoryBase<TEntity> : OrchardCoreRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected OrchardCoreRepositoryBase(IDbContextProvider<OrchardCoreDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
