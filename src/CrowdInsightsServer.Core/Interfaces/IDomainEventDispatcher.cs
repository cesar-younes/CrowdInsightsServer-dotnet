using CrowdInsightsServer.Core.SharedKernel;

namespace CrowdInsightsServer.Core.Interfaces
{
    public interface IDomainEventDispatcher
    {
        void Dispatch(BaseDomainEvent domainEvent);
    }
}