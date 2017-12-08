using System.Linq;

namespace WeAreTrvlrs.Contract.Repositories
{
    public interface IRepositoryBase<TEntity> where TEntity : class

    {
        IQueryable GetAll();
    }
}