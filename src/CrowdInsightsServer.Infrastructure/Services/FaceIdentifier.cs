using CrowdInsightsServer.Core.Entities;
using CrowdInsightsServer.Core.Interfaces;
using Microsoft.Azure.CognitiveServices.Vision.Face;
using Microsoft.Azure.CognitiveServices.Vision.Face.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CrowdInsightsServer.Infrastructure.Services
{
    public class FaceIdentifier : IFaceIdentifier
    {
        readonly static string SUBSCRIPTIONKEY = Environment.GetEnvironmentVariable("CogSerFaceKey");
        readonly static string FACEENDPOINT = Environment.GetEnvironmentVariable("CogSerFaceEndpoint");
        private FaceClient _faceClient = new FaceClient(
                new ApiKeyServiceClientCredentials(SUBSCRIPTIONKEY),
                new System.Net.Http.DelegatingHandler[] { })
        {
            Endpoint = FACEENDPOINT
        };
        private static readonly FaceAttributeType[] faceAttributes =
            { FaceAttributeType.Age, FaceAttributeType.Gender, FaceAttributeType.Emotion, FaceAttributeType.Noise, FaceAttributeType.Blur };

        public async Task<IList<DetectedFace>> DetectFacesAsync(string imageUrl)
        {
            try
            {
                IList<DetectedFace> faceList =
                    await _faceClient.Face.DetectWithUrlAsync(
                        imageUrl, true, false, faceAttributes);

                return faceList;
            }
            catch (APIErrorException e)
            {
                throw;
            }
        }

        public Task<bool> FindPersonInGroupAsync(string url, string groupId)
        {
            throw new NotImplementedException();
        }
    }
}
