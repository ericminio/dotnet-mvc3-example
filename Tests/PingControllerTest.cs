using NUnit.Framework;
using Yose.Controllers;
using System.Web.Mvc;

namespace Yose.Controllers
{
    [TestFixture]
    public class PingControllerTest
    {
        private PingController controller;

        [SetUp]
        public void NewController()
        {
            controller = new PingController();
        }

        [Test]
        public void ReturnsAJsonResult()
        {
            Assert.That(controller.Index(), Is.InstanceOf<JsonResult>());
        }

        [Test]
        public void ReturnsTheValueExpectedByYose()
        {
            var response = (JsonResult)controller.Index();
            var expected = new JsonResult { Data = new { alive = true } };

            Assert.That(response.Data.ToString(), Is.EqualTo(expected.Data.ToString()));
        }
    }
}

