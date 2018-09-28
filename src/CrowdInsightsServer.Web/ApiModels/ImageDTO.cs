using CrowdInsightsServer.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdInsightsServer.Web.ApiModels
{
    public class ImageDTO
    {
        public string URL { get; set; }
        public Guid Camera { get; set; }
    }
}
