using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication4
{
    public class server : Iserver
    {
        public server()
        {
        }
      
        public string Show()
        {
            return "这个是服务的";
        }
    }


}