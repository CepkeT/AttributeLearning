using System.Reflection;

namespace AttributeLearning;

internal class Task1Beater
{

    public void ChangeUnchangable(object @class)
    {
        var type = @class.GetType();

        var fields = type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

        foreach (var field in fields)
        {
            field.SetValue(@class, (int)field.GetValue(@class)! + 333);
        }
    }
}