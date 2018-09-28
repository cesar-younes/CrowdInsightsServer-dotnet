using CrowdInsightsServer.Core.Entities;
using Microsoft.Azure.CognitiveServices.Vision.Face.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CrowdInsightsServer.Core.Interfaces
{
    public interface IFaceIdentifier
    {
        //Task CreatePersonGroupIfNotExistsAsync(string personGroupId, string personGroupName);
        //Task<CreatePersonResult> AddEmptyPersonToGroupAsync(string personName);
        //Task AddFaceToPersonAsync(Guid personId, string imageUrl);
        //Task TrainPersonGroupAsync();
        //Task<TrainingStatus> GetTrainingStatus();
        //Task<Face[]> DetectFacesInImageAsync(string imageUrl);
        Task<IList<DetectedFace>> DetectFacesAsync(string imageUrl);
        //Task<bool> FindPersonInGroupAsync(string url, string groupId);
    }
}
