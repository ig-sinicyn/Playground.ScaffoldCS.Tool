namespace Playground.ScaffoldCS.Library;

public interface IScaffolding
{
    void Run(IScaffoldContext context);
}

public interface IScaffolding<T>
{
    void Run(IScaffoldContext context, T args);
}

public interface IScaffolding<T1, T2>
{
    void Run(IScaffoldContext context, T1 args1, T2 argsT2);
}