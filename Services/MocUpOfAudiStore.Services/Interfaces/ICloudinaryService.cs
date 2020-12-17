using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace MocUpOfAudiStore.Services.Interfaces
{
    public interface ICloudinaryService
    {
        Task<IEnumerable<string>> UploadPicturesAsync(IEnumerable<IFormFile> pictureFile);
        Task<string> UploadPictureAsync(IFormFile pictureFile);
    }
}
