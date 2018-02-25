using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApi.ImageAcquisition.Contract;

namespace WebApi.Services
{
    public class ImageService : IImageService
    {
        private readonly IImageAcquisition _imageAcquistion;

        public ImageService(IImageAcquisition imageAcquistion)
        {
            _imageAcquistion = imageAcquistion;
        }

        public ImageResponse GetImage(int id)
        {
            var imageResponse = _imageAcquistion.GetImage();

            return imageResponse;
        }

        public IEnumerable<ImageResponse> GetAllImages()
        {
            throw new NotImplementedException();
        }
    }
}