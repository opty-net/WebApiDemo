using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApi.ImageAcquisition.Contract;

namespace WebApi.ImageAcquisition.Implementation
{
    public class ImageAcquisition : IImageAcquisition
    {
        public ImageResponse GetImage()
        {
            var imageResponse = new ImageResponse { Image = "I'm pretending to be an image" };

            return imageResponse;
        }
    }
}