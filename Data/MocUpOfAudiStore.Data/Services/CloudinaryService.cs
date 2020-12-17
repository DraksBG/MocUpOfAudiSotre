using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Http;
using MocUpOfAudiStore.Services.Interfaces;

namespace MocUpOfAudiStore.Data.Services
{
    public class CloudinaryService : ICloudinaryService
    {
        private readonly Cloudinary cloudinaryUtility;

        public CloudinaryService(Cloudinary cloudinaryUtility)
        {
            this.cloudinaryUtility = cloudinaryUtility;
        }

        public async Task<IEnumerable<string>> UploadPicturesAsync(IEnumerable<IFormFile> pictureFile)
        {
            var urls = new List<string>();

            foreach (var picture in pictureFile)
            {
                var currentPictureUrl = await this.UploadPictureAsync(picture);
                urls.Add(currentPictureUrl);
            }

            return urls;
        }

        public async Task<string> UploadPictureAsync(IFormFile pictureFile)
        {
            byte[] destinationData;

            using (var ms = new MemoryStream())
            {
                await pictureFile.CopyToAsync(ms);
                destinationData = ms.ToArray();
            }

            UploadResult uploadResult = null;

            using (var ms = new MemoryStream(destinationData))
            {
                var fileName = Guid.NewGuid().ToString();
                ImageUploadParams uploadParams = new ImageUploadParams
                {
                    Folder = "car_images",
                    File = new FileDescription(fileName, ms)
                };

                uploadResult = await this.cloudinaryUtility.UploadAsync(uploadParams);
            }

            return uploadResult?.PublicId;
        }
    }
}
