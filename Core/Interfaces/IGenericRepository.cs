using Core.Entities;
using Core.Specifications;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        // This generic class will be used by classeds that derives from BaseEntity(meaning only entities)
        Task<T> GetByIdAsync(int id);
        Task<IReadOnlyList<T>> listAllAsync();

        Task<T> GetEntityWithSpec(ISpecification<T> spec);
        Task<IReadOnlyList<T>> ListAsync(ISpecification<T> spec);
    }
}