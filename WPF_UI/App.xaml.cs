using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Windows;
using WPF_UI.Configurations;

namespace WPF_UI
{
	public partial class App : Application
	{
		protected override void OnStartup(StartupEventArgs e)
		{
			var host = Host.CreateDefaultBuilder()
				.ConfigureServices(services =>
				{
					services.AddWpfBlazorWebView();
					services.AddSingleton<MainWindow>();
					services.AddDbContext<ITWareDbContext>(ServiceLifetime.Scoped);
					services.AddSingleton<DatabaseInfo>();
#if DEBUG
					services.AddBlazorWebViewDeveloperTools();
#endif
				})
				.ConfigureAppConfiguration(config =>
				{
					config.AddJsonFile("appconfig.json", optional: false, reloadOnChange: true);
				})
				.Build();

			host.Services.GetService<MainWindow>()?.Show();
			host.Services.GetService<ITWareDbContext>()?.Database.Migrate();
			base.OnStartup(e);
		}
	}
}
