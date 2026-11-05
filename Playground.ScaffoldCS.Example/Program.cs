using System.Reflection;
using Playground.ScaffoldCS.Library;

namespace Playground.ScaffoldCS.Example;

internal class Program
{
    // Args: Hello --name=world
    // Args: foo --bar=123 --baz
    static void Main(string[] args) => ScaffoldHost.Run(Assembly.GetEntryAssembly()!, args);
}