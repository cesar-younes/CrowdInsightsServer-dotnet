using CrowdInsightsServer.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdInsightsServer.Web.ApiModels
{
    public class GroupDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string UserData { get; set; }
        public DateTime CreatedDateTime { get; set; }

        public static GroupDTO FromGroup(Group group)
        {
            return new GroupDTO()
            {
                Id = group.Id,
                Name = group.Name,
                UserData = group.UserData
            };
        }
    }
}
