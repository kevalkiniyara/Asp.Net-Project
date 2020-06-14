using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace EC2Project
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
            .UseUrls("http://192.168.43.103:8020")
                .UseStartup<Startup>();
    }
}
