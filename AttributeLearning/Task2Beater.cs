using System.Reflection;

namespace AttributeLearning;

internal class Task2Beater
{

    public void ChangeUnchangable(object @class)
    {
        var type = @class.GetType();
        var fields = type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

        
        foreach (var field in fields)
        {
            switch (field.FieldType.Name)
            {
                case "Int32":
                    field.SetValue(@class, (int)field.GetValue(@class)! * 10/5);
                    break;
                case "String":
                    field.SetValue(@class, $"{field.GetValue(@class)}Уже НЕТ. Бугага!!!");
                    break;
                case "Boolean":
                    var value = (bool)field.GetValue(@class)!;
                    field.SetValue(@class, !value);
                    break;
            }
        }
    }
    
}