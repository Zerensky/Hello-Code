using System.Diagnostics;

[DebuggerDisplay("{GetDebuggerDisplay(),nq}")]
internal class NewBaseType
{
}
using System.Diagnostics;

[DebuggerDisplay(V)]
internal class NewBaseType
{
    private const string V = "{GetDebuggerDisplay(),nq}";

    private static void Main(string[] args)
    {
        Console.WriteLine("Введите ваше имя ");
        string username = Console.Readline();
        object writeLine = Console.WriteLine("Привет,");
        object writeLine = Console.WriteLine(username);
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}
