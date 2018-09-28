using CrowdInsightsServer.Core.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrowdInsightsServer.Core.Entities
{
    public class Person : BaseEntity<Guid>
    {
        public Group Group { get; set; }
        public Guid PersonGroupId { get; set; }
        //the id of this as assigned in the CogSer
        public string PersistedFaceId { get; set; }
        public string ProfilePicture { get; set; }
        public string Name { get; set; }
    }
}
