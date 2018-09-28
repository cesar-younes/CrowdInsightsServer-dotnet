using CrowdInsightsServer.Core.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrowdInsightsServer.Core.Entities
{
    public class Camera : BaseEntity<Guid>
    {
        public string Location { get; set; }
        public DateTime LastUpdateReceived { get; set; }
        public Guid FieldId { get; set; }

    }
}
