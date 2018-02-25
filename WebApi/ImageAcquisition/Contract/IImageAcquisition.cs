using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.ImageAcquisition.Contract
{
    public interface IImageAcquisition
    {
        ImageResponse GetImage();
    }
}
