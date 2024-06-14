using JetBrains.Annotations;
using Lamar;

namespace Mmu.JahrgaengerBuddy.WpfUI.Infrastructure.DependencyInjection;

[UsedImplicitly]
public class WpfUiRegistryCollection : ServiceRegistry
{
    public WpfUiRegistryCollection()
    {
        Scan(
            scanner =>
            {
                scanner.AssemblyContainingType<WpfUiRegistryCollection>();
                scanner.WithDefaultConventions();
            });
    }
}