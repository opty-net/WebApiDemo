using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApi.ImageAcquisition.Contract;

namespace WebApi.Services
{
    public class MyService : IMyService
    {
        private readonly IImageAcquisition _imageAcquistion;

        public MyService(IImageAcquisition imageAcquistion)
        {
            _imageAcquistion = imageAcquistion;
        }

        public string GetSomeStuff(int id)
        {
            var imageResponse = _imageAcquistion.GetImage();

            return imageResponse.Image;
        }

        public IEnumerable<string> GetAllStuff()
        {
            return new string[] { "value1ąę", "value2ŚĆ" };
        }
    }
}