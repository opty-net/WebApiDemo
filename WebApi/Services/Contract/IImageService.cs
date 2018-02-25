using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.ImageAcquisition.Contract;

namespace WebApi.Services
{
    public interface IImageService
    {
        ImageResponse GetImage(int id);
        IEnumerable<ImageResponse> GetAllImages();
    }
}
