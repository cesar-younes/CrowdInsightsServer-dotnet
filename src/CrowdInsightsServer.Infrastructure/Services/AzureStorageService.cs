using CrowdInsightsServer.Core.Interfaces;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace CrowdInsightsServer.Infrastructure.Services
{
    public class AzureStorageService : IImageStorage
    {
        public async Task<bool> DeleteFile(string fileName)
        {
            CloudStorageAccount account = CloudStorageAccount.Parse(Environment.GetEnvironmentVariable("StorageConnectionString"));
            CloudBlobClient blobClient = account.CreateCloudBlobClient();
            CloudBlobContainer blobContainer = blobClient.GetContainerReference("images");
            CloudBlockBlob blockBlob = blobContainer.GetBlockBlobReference(fileName);
            
            return await blockBlob.DeleteIfExistsAsync();
        }

        public async Task<string> UploadFile(Stream imageStream)
        {
            CloudStorageAccount account = CloudStorageAccount.Parse(Environment.GetEnvironmentVariable("StorageConnectionString"));
            CloudBlobClient blobClient = account.CreateCloudBlobClient();
            CloudBlobContainer blobContainer = blobClient.GetContainerReference("images");
            CloudBlockBlob blockBlob = blobContainer.GetBlockBlobReference(Guid.NewGuid().ToString()+".jpg");
            await blockBlob.UploadFromStreamAsync(imageStream);

            return blockBlob.StorageUri.PrimaryUri.ToString();
        }
    }
}
