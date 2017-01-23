using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyConsole
{
    public class server : Iserver
    {
        public server()
        {
            Console.WriteLine(" 这个是没有参数的构造函数");
        }
      

          public  server(string name)
        {
            Console.WriteLine(" 这个是带参数的构造函数---"+name);

        }
        public string Show()
        {
            return "这是无参数的服务";
        }
    }


    public class ServerWithParms : Iserver
    {
        public ServerWithParms(string Pname)
        {
            Console.WriteLine(Pname);
        }
        public string Show()
        {
            return "这是个带参数的服务";
        }
    }


    public class Whelp : Iwrite
    {
        public void Write(string name)
        {
            Console.WriteLine("这就是我写的name"+name);
        }
    }

    public class MyHelp : IMY
    {
        public Iwrite _iwrite;
        public MyHelp(Iwrite iw)
        {
            this._iwrite = iw;
        }
        public void MyWrite(string name)
        {
            _iwrite.Write(name);
        }
    }
}