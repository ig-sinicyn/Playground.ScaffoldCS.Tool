using Playground.ScaffoldCS.Library;

namespace Playground.ScaffoldCS.Example;

public class FooScaffold : IScaffolding<FooScaffold.Args>
{
    public class Args
    {
        public  int Bar { get; set; }

        public  bool Baz { get; set; }
    }

    public void Run(IScaffoldContext context, Args args)
    {
        context.Write($"Foo #{args.Bar}: {args.Baz}");
    }
}