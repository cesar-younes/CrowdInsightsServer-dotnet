using System;
using System.Collections.Generic;
using System.Text;

namespace CrowdInsightsServer.Core.Entities
{
    public class FaceDimensions
    {
        public string FaceId { get; set; }
        public FaceRectangle FaceRectangle { get; set; }
        public Guid FaceGuid
        {
            get
            {
                return Guid.Parse(FaceId);
            }
            set { }
        }
    }

    public class FaceRectangle
    {
        public int top { get; set; }
        public int left { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }
}
