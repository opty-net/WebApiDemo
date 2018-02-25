using System;
using WebApi.ImageAcquisition.Contract;
using System.Drawing.Imaging;

namespace WebApi.ImageAcquisition.Implementation
{
    public class ImageAcquisitionModuleStub : IImageAcquisition
    {
        public ImageResponse GetImage()
        {
            var imageResponse = new ImageResponse
            {
                ImageName = Guid.NewGuid().ToString(),
                ImageFormat = ImageFormat.Png.ToString(),
                Image = "I'm pretending to be an image"
            };

            return imageResponse;
        }
    }
}