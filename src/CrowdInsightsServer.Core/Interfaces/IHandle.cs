using CrowdInsightsServer.Core.SharedKernel;

namespace CrowdInsightsServer.Core.Interfaces
{
    public interface IHandle<T> where T : BaseDomainEvent
    {
        void Handle(T domainEvent);
    }
}