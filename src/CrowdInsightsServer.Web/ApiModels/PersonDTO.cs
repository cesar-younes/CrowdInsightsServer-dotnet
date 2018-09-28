using CrowdInsightsServer.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdInsightsServer.Web.ApiModels
{
    public class PersonDTO
    {
        public Guid Id { get; set; }
        public Guid GroupId { get; set; }
        public string GroupName { get; set; }
        public Guid PersonGroupId { get; set; }
        //the id of this as assigned in the CogSer
        public string PersistedFaceId { get; set; }
        public string ProfilePicture { get; set; }
        public string Name { get; set; }

        public static PersonDTO FromPerson(Person person)
        {
            return new PersonDTO()
            {
                Id = person.Id,
                Name = person.Name,
                ProfilePicture = person.ProfilePicture,
                PersistedFaceId = person.PersistedFaceId,
                GroupId = person.Group.Id,
                GroupName = person.Group.Name,
                PersonGroupId = person.PersonGroupId                
            };
        }
    }
}
