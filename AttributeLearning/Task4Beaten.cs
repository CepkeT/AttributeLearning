namespace AttributeLearning;

[TaskModifyField(TargetType = typeof(bool), TargetModificationValue = "Inversion")]
[TaskModifyField(TargetType = typeof(int), TargetModificationValue = "Add 10")]
[TaskModifyField(TargetType = typeof(string), TargetModificationValue = "Prefix fire!!!")]
internal class Task4Beaten
{
    [TaskModifyField]
    private int _noOneChangeMe = 555;
    [TaskModifyField]
    private bool _noOneChangeMeForShure = true;
    private string _noOneChangeMeForShureISay = "NO ONE!!! DO NOT TOUCH THIS!!!";
    private int _noOneNoOneChangeMe = 10000000;
    [TaskModifyField]
    private bool _noOneNoOneChangeMeForShure = false;
    [TaskModifyField]
    private string _noOneNoOneChangeMeForShureISay = "NO ONE!!! NO ONE!!! NO ONE!!! DO NOT TOUCH THIS!!!";
    
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