using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace CrowdInsightsServer.Core.Interfaces
{
    public interface IImageStorage
    {
        Task<string> UploadFile(Stream imageStream);
        Task<bool> DeleteFile(string fileName);
    }
}
