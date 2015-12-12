using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.SelfHost;

namespace Padmate.Allen.SelfHost
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly.Load("Padmate.Allen.RestfulWebApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null");

            HttpSelfHostConfiguration configuration = new HttpSelfHostConfiguration("http://localhost/consolehost");

            using (HttpSelfHostServer httpServer = new HttpSelfHostServer(configuration))
            {
                httpServer.Configuration.Routes.MapHttpRoute(
                    name: "DefaultApi",
                    routeTemplate: "api/{controller}/{name}",
                    defaults: new { name = RouteParameter.Optional });


                httpServer.OpenAsync().Wait();
                Console.Read();
            }
        }
    }
}
