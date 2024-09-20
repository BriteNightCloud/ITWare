using ApplicationLayer.Services;
using Domain.Interfaces.Repositories.Equipment;
using Domain.Interfaces.Repositories.Location;
using Infrastructure.Data;
using Infrastructure.Data.Repositories;
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
					services.AddScoped<IEquipmentRepository, EquipmentRepository>();
					services.AddScoped<IEquipmentCategoryRepository, EquipmentCategoryRepository>();
					services.AddScoped<IStoredLocationRepository, StoredLocationRepository>();
					services.AddScoped<IInUseLocationRepository, InUseLocationRepository>();
					services.AddScoped<EquipmentService>();
					services.AddScoped<EquipmentCategoryService>();
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
