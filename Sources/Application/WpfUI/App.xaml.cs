using Mmu.Mlh.WpfCoreExtensions.Areas.Initialization.Orchestration.Models;
using Mmu.Mlh.WpfCoreExtensions.Areas.Initialization.Orchestration.Services;
using System.Configuration;
using System.Data;
using System.Windows;

namespace Mmu.JahrgaengerBuddy.WpfUI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : System.Windows.Application
    {
        protected override async void OnStartup(StartupEventArgs e)
        {
            var assembly = typeof(App).Assembly;
            var windowConfig = WindowConfiguration.CreateWithDefaultIcon(assembly, "Jahrgänger Buddy", 620, 600);

            await AppStartService.StartAppAsync(new WpfAppConfiguration(assembly, windowConfig, false));
        }
    }

}
