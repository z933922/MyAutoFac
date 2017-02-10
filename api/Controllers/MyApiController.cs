using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace api.Controllers
{

    [Authorize]
    [RoutePrefix("api")]   //     [RouteArea("Admin")]这个的目的是 这个路由的前缀是 api/myapi

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



        [HttpGet, Route("aa/{dd?}")]
        public string GetValue()
        {
            return "this is new string";
        }

        [HttpGet, Route("GG/{dd=xxoo}/{ee=eeeeee}")]
        public string GetDefault(string dd, string ee)
        {
            return "dd:" + dd + " ee:" + ee;
        }

        [HttpGet]
        [Route("{num:int:min(10)}")]
        
        public string yueshu(int num=23)
        {
            return num.ToString();
        }
    }
}
