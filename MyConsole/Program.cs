using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Autofac.Configuration;

namespace MyConsole
{
    class Program
    {
        private static IContainer Container { get; set; }
        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();



            // Usually you're only interested in exposing the type
            // via its interface:
         
            builder.RegisterType<server>().As<Iserver>();
            builder.RegisterType<ServerWithParms>().AsSelf().As<Iserver>().WithParameter("Pname", "sectionName");
            // However, if you want BOTH services (not as common)
            // you can say so:
            //   builder.Register(c => new ServerWithParms("xxx")).As<Iserver>();
            builder.RegisterType<Whelp>().As<Iwrite>();
            builder.RegisterType<MyHelp>().As<IMY>();

            //   组件只能被注册一次
          

            builder.RegisterType<server>().As<Iserver>().WithParameter("name","这是参数");
            builder.RegisterType<server>().As<Iserver>();


            //  注册一个实例
            server myserver = new server(" 这就是你妈逼的参数");
            builder.RegisterInstance(myserver).As<Iserver>();


            // 也可以注册一个linq 的表达式

            builder.Register(c => new server("这就是大傻逼参数")).As<Iserver>();


            Container= builder.Build();


           // builder.RegisterModule(new ConfigurationSettingsReader());

            using (var scope=Container.BeginLifetimeScope())
            {
                //   var showmethod = scope.Resolve<IMY>();
                // showmethod.MyWrite("哈哈");
                // 如果有多级的话 推荐使用多级beginlifescope  释放内存要快些

                var blea = scope.Resolve<Iserver>();
            }

            Console.ReadKey();
        }
    }
}
