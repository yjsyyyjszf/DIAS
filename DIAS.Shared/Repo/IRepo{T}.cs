﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace DIAS
{
    public interface IRepo<T> : IRepository where T : IAggregateRoot
    {
        int Save(T entity);
        Task<int> SaveAsync(T entity);

        int Delete(int id);
        Task<int> DeleteAsync(int id);

        int Delete(T entity);
        Task<int> DeleteAsync(T entity);

        int Add(T entity);
        Task<int> AddAsync(T entity);

        T GetOne(int? id);
        ValueTask<T> GetOneAsync(int? id);

        IEnumerable<T> GetAll();
        Task<IEnumerable<T>> GetAllAsync();
    }
}
