using Microsoft.AspNetCore.Blazor.Hosting;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace FlightFinder.Client
{
	public class Program
	{
		public static void Main(string[] args)
		{
			CreateHostBuilder(args).Build().Run();
		}

		//public static IHostBuilder CreateHostBuilder(string[] args) =>
		//  Host.CreateDefaultBuilder(args)
		//	  .ConfigureWebHostDefaults(webBuilder =>
		//	  {
		//		  webBuilder.UseStartup<Startup>();
		//	  });

		public static IWebAssemblyHostBuilder CreateHostBuilder(string[] args) =>
			BlazorWebAssemblyHost
				.CreateDefaultBuilder()
				.UseBlazorStartup<Startup>();
	}
}
