using CrowdInsightsServer.Core.Interfaces;
using CrowdInsightsServer.Core.SharedKernel;

namespace CrowdInsightsServer.Tests
{
    public class NoOpDomainEventDispatcher : IDomainEventDispatcher
    {
        public void Dispatch(BaseDomainEvent domainEvent) { }
    }
}
