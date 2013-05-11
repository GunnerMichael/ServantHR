using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ServantHR.Api.Models;

namespace ServantHR.Api.Controllers
{
    public class JobTitleController : ApiController
    {
        public HttpResponseMessage PostNewJobTitle(NewJobTitle item)
        {
            // item = repository.Add(item);

            JobTitle title = new JobTitle();

            var response = Request.CreateResponse<JobTitle>(HttpStatusCode.Created, title);

            string uri = Url.Link("JobTitle", new { id = title.Id });
            response.Headers.Location = new Uri(uri);
            return response;
        }
    }
}
