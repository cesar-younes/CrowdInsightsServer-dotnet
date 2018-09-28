using CrowdInsightsServer.Core.Entities;
using CrowdInsightsServer.Core.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrowdInsightsServer.Core.Events
{
    public class PersonDetectedEvent : BaseDomainEvent
    {
        public Person PersonDetected { get; set; }

        public PersonDetectedEvent(Person personDetected)
        {
            PersonDetected = personDetected;
        }
    }
}
