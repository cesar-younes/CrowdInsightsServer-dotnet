using CrowdInsightsServer.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdInsightsServer.Web.ApiModels
{
    public class LogItemDTO
    {
        public Guid Id { get; set; }
        public Guid PersonId { get; set; }
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

        public static LogItemDTO FromLogItem(LogItem item)
        {
            return new LogItemDTO()
            {
                Id = item.Id,
                PersonId = item.Person.Id,
                Age = item.Age,
                Anger = item.Anger,
                Camera = item.Camera,
                Contempt = item.Contempt,
                CreatedDateTime = item.CreatedDateTime,
                Disgust = item.Disgust,
                Fear = item.Fear,
                Gender = item.Gender,
                Happiness = item.Happiness,
                Neutral = item.Neutral,
                Sadness = item.Sadness,
                Surprise = item.Surprise
            };
        }
    }
}
