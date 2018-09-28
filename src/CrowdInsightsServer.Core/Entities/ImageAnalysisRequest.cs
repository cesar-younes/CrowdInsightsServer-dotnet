using CrowdInsightsServer.Core.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrowdInsightsServer.Core.Entities
{
    public class ImageAnalysisRequest : BaseEntity<Guid>
    {
        public string URL { get; set; }
        public string SenderDevice { get; set; }
        public bool Processed { get; set; }
    }
}
