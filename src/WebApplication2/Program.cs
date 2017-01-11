﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;

namespace WebApplication2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .UseUrls("http://0.0.0.0:5000")
                .Build();

            //var host = new WebHostBuilder()
            //            .UseServer("Microsoft.AspNetCore.Server.Kestrel")
            //            .UseApplicationBasePath(Directory.GetCurrentDirectory())
            //            .UseDefaultConfiguration(args)
            //            .UseIISPlatformHandlerUrl()
            //            .UseStartup<Startup>()
            //            .UseUrls("http://localhost:5050")
            //            .Build();

            host.Run();

            host.Run();
        }
    }
}
