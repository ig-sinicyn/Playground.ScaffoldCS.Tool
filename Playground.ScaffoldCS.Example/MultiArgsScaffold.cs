using Playground.ScaffoldCS.Library;

namespace Playground.ScaffoldCS.Example;

public class MultiArgsScaffold : IScaffolding<MultiArgsScaffold.Args1, MultiArgsScaffold.Args2>
{
    public class Args1
    {
        public  int Bar { get; set; }

        public  bool Baz { get; set; }
    }

    public class Args2
    {
        public required string Detail { get; set; }
    }

    public void Run(IScaffoldContext context, Args1 args1, Args2 args2)
    {
        context.Write($"Foo #{args1.Bar}: {args1.Baz} ({args2.Detail})");
    }
}