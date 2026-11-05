using System.Reflection;
using Playground.ScaffoldCS.Library;

namespace Playground.ScaffoldCS.Example;

internal class Program
{
    // Args: Hello --name=world
    static void Main(string[] args) => ScaffoldHost.Run(Assembly.GetEntryAssembly()!, args);
}