using System;
using Microsoft.EntityFrameworkCore;
namespace Repository.IRepository
{
    public interface IUnitOfWork
    {
        void Commit();
        void Dispose();
        void Add<T>(DbContext context) where T : class;
        void delete<T>(DbContext context) where T : class;
        void update<T>(DbContext context) where T : class;
    }
}

