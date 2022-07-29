using Microsoft.AspNetCore.Mvc;
using Slcf_MAPA.WebApi.Models;
using System.Net.Http;

namespace Slcf_MAPA.WebApi.Controller
{
    public class Dynamics365Controller : ApiModel
    {
        [Route("api/dynamics")]
        [HttpGet]
        public HttpResponseMessage GetRecords()
        {
            return new HttpResponseMessage(System.Net.HttpStatusCode.OK);
        }
    }
}
