using CrowdInsightsServer.Core.Entities;
using CrowdInsightsServer.Core.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrowdInsightsServer.Core.Events
{
    public class QueueImageForAnalysisEvent : BaseDomainEvent
    {
        public ImageAnalysisRequest ImageAnalysisRequest { get; set; }

        public QueueImageForAnalysisEvent(ImageAnalysisRequest imageAnalysisRequest)
        {
            ImageAnalysisRequest = imageAnalysisRequest;
        }
    }
}
