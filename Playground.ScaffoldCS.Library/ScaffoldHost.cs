using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace Playground.ScaffoldCS.Library;

public static class ScaffoldHost
{
    public static void Run(Assembly assembly, string[] args)
    {
        // TODO: bind to the template (implements IScaffolding<T>)
        // and invoke it. Pass args (based on T props) and types from DI

        var services = new ServiceCollection();
        services.AddSingleton<IScaffoldContext, ScaffoldContext>();

        using var provider = services.BuildServiceProvider();

        // ???
    }
}