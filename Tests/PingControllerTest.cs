using NUnit.Framework;
using System.Web.Mvc;
using Yose.Controllers;

namespace Yose
{
    [TestFixture]
    public class PingControllerTest
    {
        [Test]
        public void ReturnsJsonResult()
        {
            Assert.That(new PingController().Index(), Is.InstanceOf<JsonResult>());
        }

        [Test]
        public void ReturnsValueExpetedByYose()
        {
            var response = (JsonResult)new PingController().Index();
            var expected = new JsonResult { Data = new { alive = true } };

            Assert.That(response.Data.ToString(), Is.EqualTo(expected.Data.ToString()));
        }
    }
}

