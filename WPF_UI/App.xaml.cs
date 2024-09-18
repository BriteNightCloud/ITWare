using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Windows;

namespace WPF_UI
{
	public partial class App : Application
	{
		protected override void OnStartup(StartupEventArgs e)
		{
			var host = Host.CreateDefaultBuilder()
				.ConfigureAppConfiguration(config =>
				{
					config.AddJsonFile("appconfig.json", optional: false, reloadOnChange: true);
				})
				.ConfigureServices((hostContext, services) =>
				{
					services.Configure<IConfiguration>(hostContext.Configuration);

					services.AddWpfBlazorWebView();
					services.AddSingleton<MainWindow>();
					services.AddDbContext<ITWareDbContext>(ServiceLifetime.Scoped);
					services.AddScoped(typeof(Repository<>));
#if DEBUG
					services.AddBlazorWebViewDeveloperTools();
#endif
				})
				.Build();

			host.Services.GetService<MainWindow>()?.Show();
			host.Services.GetService<ITWareDbContext>()?.Database.Migrate();
			base.OnStartup(e);
		}
	}
}
