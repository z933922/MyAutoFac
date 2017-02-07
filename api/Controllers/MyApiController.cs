using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace api.Controllers
{

    //[RoutePrefix("api/MyApi")]
    public class MyApiController : ApiController
    {

       [HttpGet]
        public string Index()
        {
            return "12321";
        }


        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }



        [HttpGet,Route("aa/{dd?}")]
        public string GetValue()
        {
            return "this is new string";
        }

    }
}
