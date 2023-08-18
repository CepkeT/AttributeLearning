using System.Reflection;

namespace AttributeLearning;

internal class Task3Beater
{

    public void ChangeUnchangable(object @class)
    {
        var type = @class.GetType();

        var fields = type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
        
        foreach (var field in fields)
        {
            var attrs = field.CustomAttributes;
            foreach (var attr in attrs)
            {
                if (attr.AttributeType.Name == "MyModifiedAttribute")
                {
                    switch (field.GetValue(@class))
                    {
                        case bool _:
                            field.SetValue(@class, !(field.GetValue(@class) as bool?));
                            break;
                        case int _:
                            field.SetValue(@class, (field.GetValue(@class) as int?) * 10);
                            break;
                        case string _:
                            field.SetValue(@class, (field.GetValue(@class) as string) + "И снова Нет");
                            break;
                    }
                }
            }
        }
    }
}