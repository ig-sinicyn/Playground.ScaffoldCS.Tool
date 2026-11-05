namespace Playground.ScaffoldCS.Library;

public interface IScaffolding
{
    void Run(IScaffoldContext context);
}

public interface IScaffolding<T>
{
    void Run(IScaffoldContext context, T args);
}