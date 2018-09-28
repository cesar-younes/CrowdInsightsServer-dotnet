using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CrowdInsightsServer.Core.Entities;
using CrowdInsightsServer.Core.Events;
using CrowdInsightsServer.Core.Interfaces;
using CrowdInsightsServer.Infrastructure.Data;
using CrowdInsightsServer.Web.ApiModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace CrowdInsightsServer.Web.Api
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [Consumes("application/json","application/json-path+json", "multipart/form-data")]
    [ApiController]
    public class ImagesController : ControllerBase
    {
        private readonly IRepository<ImageAnalysisRequest> _repository;
        public IConfiguration Configuration { get; set; }

        private readonly IImageStorage _imageStorage;

        public ImagesController(IRepository<ImageAnalysisRequest> repository, IConfiguration configuration, IImageStorage imageStorage)
        {
            _repository = repository;
            Configuration = configuration;
            _imageStorage = imageStorage;
        }

        // POST: api/LogItems
        [HttpPost("Analyze")]
        public async Task<IActionResult> PostImageForAnalysis(IFormFile image)
        {
            Stream stream = image.OpenReadStream();
            string name = image.FileName;
            string uri = await _imageStorage.UploadFile(stream);

            ImageAnalysisRequest imageAnalysisRequest = new ImageAnalysisRequest()
            {
                Id = Guid.NewGuid(),
                SenderDevice = name,
                URL = uri,
                Processed = false
            };

            imageAnalysisRequest.Events.Add(new QueueImageForAnalysisEvent(imageAnalysisRequest));
            _repository.Add(imageAnalysisRequest);

            return CreatedAtAction("StartNewImageAnalysisRequest", new { id = imageAnalysisRequest.Id, url = uri });
        }
    }
}