using System.Collections.Generic;
using System.Web.Http;
using WebApi.ImageAcquisition.Contract;
using WebApi.Services;

namespace WebApi.Controllers
{
    public class ImagesController : ApiController
    {
        private readonly IImageService _myService;

        public ImagesController(IImageService myService)
        {
            _myService = myService;
        }

        // GET api/values
        public IEnumerable<ImageResponse> Get()
        {
            return _myService.GetAllImages();
        }

        // GET api/values/5
        public ImageResponse Get(int id)
        {
            return _myService.GetImage(id);
        }

        //// POST api/values
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/values/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/values/5
        //public void Delete(int id)
        //{
        //}
    }
}
