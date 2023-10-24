using Library.Core.Entities;
using Library.Data.Repositories.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.UnitOfWorks
{
    public interface IUnitOfWork: IAsyncDisposable
    {
        IRepository<T> GetRepository<T> () where T : class, IEntityBase, new();

        Task<int> SaveAsync();
        int Save();

    }
}
