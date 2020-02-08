using Microsoft.AspNetCore.Blazor.Hosting;
using System.Net.Http;
using System.Threading.Tasks;
using Blazor.Fluxor;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using System.Reflection;
using System;
using Microsoft.AspNetCore.Components;

namespace FlightFinder.Client
{
	public class Program
	{
		public static async Task Main(string[] args)
		{
			var builder = WebAssemblyHostBuilder.CreateDefault(args);
			AddHttpClient(builder.Services);


			builder.Services.AddFluxor(options =>
			{
				options.UseDependencyInjection(typeof(Program).Assembly);
				options.AddMiddleware<Blazor.Fluxor.ReduxDevTools.ReduxDevToolsMiddleware>();
			});
			builder.RootComponents.Add<App>("app");
			await builder.Build().RunAsync();
		}


		public static void AddHttpClient(IServiceCollection services)
		{
			var httpSvc = services.Single(x => x.ServiceType == typeof(HttpClient));
			services.Remove(httpSvc);

			// we add the WasmHttpMessageHandler
			Type MonoWasmHttpMessageHandlerType = Assembly
				.Load("WebAssembly.Net.Http")
				.GetType("WebAssembly.Net.Http.HttpClient.WasmHttpMessageHandler");

			services.AddScoped(MonoWasmHttpMessageHandlerType);

			// example of the "local" HttpClient configuration
			services.AddHttpClient("local", (s, h) =>
			{
				// Creating the URI helper needs to wait until the JS Runtime is initialized, so defer it.
				var navigationManager = s.GetRequiredService<NavigationManager>();
				h.BaseAddress = new Uri("http://localhost:59912/");
			})
			.ConfigurePrimaryHttpMessageHandler(sp => (HttpMessageHandler)sp.GetService(MonoWasmHttpMessageHandlerType));

			// this is for backwards compatibility
			services.AddTransient<HttpClient>(s =>
			{
				var factory = s.GetService<IHttpClientFactory>();
				return factory.CreateClient("local");
			});
		}
	}
}
