//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net.Http;
//using System.Text;
//using System.Web.Http;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using WebApi;
//using WebApi.Controllers;
//using WebApi.Services;

//namespace WebApi.Tests.Controllers
//{
//    [TestClass]
//    public class ValuesControllerTest
//    {
//        ImagesController controller;

//        [TestInitialize]
//        public void Initialize()
//        {
//            IImageService iMyService = new ImageService();
//            controller = new ImagesController(iMyService);
//        }

//        [TestMethod]
//        public void Get()
//        {
//            // Arrange


//            // Act
//            IEnumerable<string> result = controller.Get();

//            // Assert
//            Assert.IsNotNull(result);
//            Assert.AreEqual(2, result.Count());
//            Assert.AreEqual("value1", result.ElementAt(0));
//            Assert.AreEqual("value2", result.ElementAt(1));
//        }

//        [TestMethod]
//        public void GetById()
//        {
//            // Arrange


//            // Act
//            string result = controller.Get(5);

//            // Assert
//            Assert.AreEqual("value", result);
//        }

//        [TestMethod]
//        public void Post()
//        {
//            // Arrange


//            // Act
//            controller.Post("value");

//            // Assert
//        }

//        [TestMethod]
//        public void Put()
//        {
//            // Arrange


//            // Act
//            controller.Put(5, "value");

//            // Assert
//        }

//        [TestMethod]
//        public void Delete()
//        {
//            // Arrange


//            // Act
//            controller.Delete(5);

//            // Assert
//        }
//    }
//}
