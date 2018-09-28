using System;
using System.Collections.Generic;
using CrowdInsightsServer.Core.SharedKernel;

namespace CrowdInsightsServer.Core.Interfaces
{
    public interface IRepository<T> where T : BaseEntity<Guid>
    {
        T GetById(Guid id);
        List<T> List();
        T Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}