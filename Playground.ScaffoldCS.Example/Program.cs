using System.Reflection;
using Playground.ScaffoldCS.Library;

namespace Playground.ScaffoldCS.Example;

// TODO: emit implicitly, like MTP tests do
internal class Program
{
    // Examples:
    // * Hello --name=world
    // * foo --bar=123 --baz
    // * multiargs --bar=123 --baz --details="Some details"
    static void Main(string[] args) => ScaffoldHost.Run(Assembly.GetEntryAssembly()!, args);
}