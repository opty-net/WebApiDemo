using System;
using WebApi.ImageAcquisition.Contract;
using System.Drawing.Imaging;
using System.Drawing;
using System.IO;

namespace WebApi.ImageAcquisition.Implementation
{
    public class JpgFromFileModule : IImageAcquisition
    {
        public ImageResponse GetImage()
        {
            var imageResponse = new ImageResponse
            {
                ImageFormat = ImageFormat.Jpeg.ToString(),
                ImageName = Guid.NewGuid().ToString(),
            };

            imageResponse.Image = GetJpgImageFromFile();

            return imageResponse;
        }

        private string GetJpgImageFromFile()
        {
            Image image = Image.FromFile("c:\\Images\\Bigger.jpg");

            var imageString = ImageToString(image);

            return imageString;
        }

        private string ImageToString(Image image)

        {
            MemoryStream ms = new MemoryStream();

            image.Save(ms, image.RawFormat);

            byte[] array = ms.ToArray();

            return Convert.ToBase64String(array);

        }
    }
}