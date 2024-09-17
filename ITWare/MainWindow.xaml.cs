using System.Windows;
using EntityFramework;
using Microsoft.Extensions.DependencyInjection;

namespace ITWare
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddWpfBlazorWebView();
            serviceCollection.AddDbContext<ITWareDbContext>(optionsLifetime: ServiceLifetime.Singleton);
#if DEBUG
            serviceCollection.AddBlazorWebViewDeveloperTools();
#endif
            Resources.Add("services", serviceCollection.BuildServiceProvider());
        }
    }
}