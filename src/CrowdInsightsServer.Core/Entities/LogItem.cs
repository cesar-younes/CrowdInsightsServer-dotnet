using CrowdInsightsServer.Core.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrowdInsightsServer.Core.Entities
{
    public class LogItem : BaseEntity<Guid>
    {
        public Person Person { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public double Anger { get; set; }
        public double Contempt { get; set; }
        public double Disgust { get; set; }
        public double Fear { get; set; }
        public double Happiness { get; set; }
        public double Neutral { get; set; }
        public double Sadness { get; set; }
        public double Surprise { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public string Camera { get; set; }
    }
}
