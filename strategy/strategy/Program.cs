using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using strategy.BLL;

namespace strategy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            Querying();

            CreateHostBuilder(args).Build().Run();

        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

        
        private static void Querying()
        {
            var acBO = new AccountBO();
            var accs = acBO.GetAllByProject();
            var accId = acBO.GetInfoBy("cwordesworth1i@oracle.com");
        }
    }
}
