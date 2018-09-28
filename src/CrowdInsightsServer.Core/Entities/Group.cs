using CrowdInsightsServer.Core.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrowdInsightsServer.Core.Entities
{
    public class Group : BaseEntity<Guid>
    {
        public string Name { get; set; }
        public string UserData { get; set; }
    }
}
