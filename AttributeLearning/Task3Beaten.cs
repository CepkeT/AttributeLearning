namespace AttributeLearning;

internal class Task3Beaten
{
    private int _noOneChangeMe = 555;
    [TaskModifyField]
    private bool _noOneChangeMeForShure = true;
    private string _noOneChangeMeForShureISay = "Не трож меня смерд";
    private int _noOneNoOneChangeMe = 10000000;
    [TaskModifyField]
    private bool _noOneNoOneChangeMeForShure = false;
    private string _noOneNoOneChangeMeForShureISay = "Ни кто не смеет меня трогать";
    
    
    public void PrintVariables()
    {
        Console.WriteLine($"Значение переменной _noOneChangeMe: {_noOneChangeMe}");
        Console.WriteLine($"Значение переменной _noOneChangeMe: {_noOneChangeMeForShure}");
        Console.WriteLine($"Значение переменной _noOneChangeMe: {_noOneChangeMeForShureISay}");
        Console.WriteLine($"Значение переменной _noOneChangeMe: {_noOneNoOneChangeMe}");
        Console.WriteLine($"Значение переменной _noOneChangeMe: {_noOneNoOneChangeMeForShure}");
        Console.WriteLine($"Значение переменной _noOneChangeMe: {_noOneNoOneChangeMeForShureISay}");
    }
}