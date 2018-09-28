using Ardalis.GuardClauses;
using CrowdInsightsServer.Core.Entities;
using CrowdInsightsServer.Core.Events;
using CrowdInsightsServer.Core.Interfaces;
using Microsoft.Azure.CognitiveServices.Vision.Face.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrowdInsightsServer.Core.Services
{
    public class ImageAnalysisService : IHandle<QueueImageForAnalysisEvent>
    {
        private readonly IFaceIdentifier _faceIdentifier;
        private readonly IRepository<ImageAnalysisRequest> _repository;

        public ImageAnalysisService(IFaceIdentifier faceIdentifier, IRepository<ImageAnalysisRequest> repository)
        {
            _faceIdentifier = faceIdentifier;
            _repository = repository;
        }

        public async void Handle(QueueImageForAnalysisEvent domainEvent)
        {
            Guard.Against.Null(domainEvent, nameof(domainEvent));

            var facesDetected = await _faceIdentifier.IdentifyFacesAsync(domainEvent.ImageAnalysisRequest.URL);

            foreach(DetectedFace face in facesDetected)
            {
                double? age = face.FaceAttributes.Age;
                string gender = face.FaceAttributes.Gender.ToString();
                var emotion = face.FaceAttributes.Emotion;
            }
        }
    }
}
