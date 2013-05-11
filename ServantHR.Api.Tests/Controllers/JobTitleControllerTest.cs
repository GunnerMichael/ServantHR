using System;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Hosting;
using System.Web.Http.Routing;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServantHR.Api.Controllers;

namespace ServantHR.Api.Tests.Controllers
{
    [TestClass]
    public class JobTitleControllerTest
    {
        [TestMethod]
        public void TestCanAddNewJobTitle()
        {
            var controller = new JobTitleController();

            SetupPostControllerForTest(controller);

            controller.PostNewJobTitle(new Models.NewJobTitle() { Title = "Developer" });
        }


        public static void SetupPostControllerForTest(ApiController controller)
        {

            var config = new HttpConfiguration();
            var request = new HttpRequestMessage(HttpMethod.Post, "http://localhost/api/courses/course");

            var route = config.Routes.MapHttpRoute(
        name: "JobTitle",
        routeTemplate: "{controller}/{action}/{id}",
        defaults: new { controller = "JobTitle", action = "Index", id = UrlParameter.Optional }
);

            var routeData = new HttpRouteData(route, new HttpRouteValueDictionary { { "controller", "courses" }, { "action", "course" } });

            controller.ControllerContext = new HttpControllerContext(config, routeData, request);
            controller.Request = request;
            controller.Request.Properties[HttpPropertyKeys.HttpConfigurationKey] = config;
            controller.Request.Properties[HttpPropertyKeys.HttpRouteDataKey] = routeData;

        }

    }
}
