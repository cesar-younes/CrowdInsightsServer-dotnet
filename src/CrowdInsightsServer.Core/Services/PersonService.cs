using Ardalis.GuardClauses;
using CrowdInsightsServer.Core.Events;
using CrowdInsightsServer.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrowdInsightsServer.Core.Services
{
    class PersonService : IHandle<PersonDetectedEvent>
    {
        public void Handle(PersonDetectedEvent domainEvent)
        {
            Guard.Against.Null(domainEvent, nameof(domainEvent));

            // Update the dashboard for this person
        }
    }
}
