namespace Playground.ScaffoldCS.Library;

public class ScaffoldContext: IScaffoldContext
{
    public void Write(string data) => Console.Write(data);
}