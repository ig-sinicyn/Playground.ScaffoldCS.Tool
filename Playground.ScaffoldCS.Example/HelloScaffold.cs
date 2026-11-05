using Playground.ScaffoldCS.Library;

namespace Playground.ScaffoldCS.Example;

public class HelloScaffold : IScaffolding<HelloScaffold.HelloArgs>
{
    public class HelloArgs
    {
        public required string Name { get; set; }
    }

    public void Run(IScaffoldContext context, HelloArgs args)
    {
        context.Write($"Hello, {args.Name}!");
    }
}