using System.Reflection;

namespace AttributeLearning;

internal class Task4Beater
{
    public void ChangeUnchangable(object @class)
    {
        var type = @class.GetType();
        var customAttributes = type.GetCustomAttributes(true);
        var fields = type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

        foreach (var attributes in customAttributes)
        {
            if (attributes is TaskModifyFieldAttribute myAttributes)
            {
                switch (myAttributes.TargetType?.Name.ToLower())
                {
                    case "int32":
                        if (myAttributes.TargetModificationValue?.ToString()?.ToLower() == "add 10")
                        {
                            foreach (var field in fields)
                            {
                                if (field.GetValue(@class) is int fieldValue)
                                {
                                    field.SetValue(@class, fieldValue + 10);
                                }
                            }
                        }

                        break;

                    case "string":
                        if (myAttributes.TargetModificationValue?.ToString() == "Prefix fire!!!")
                        {
                            foreach (var field in fields)
                            {
                                if (field.GetValue(@class) is string fieldValue)
                                {
                                    field.SetValue(@class, fieldValue + "Против лома нет приема");
                                }
                            }
                        }

                        break;

                    case "boolean":
                        if (myAttributes.TargetModificationValue?.ToString()?.ToLower() == "inversion")
                        {
                            foreach (var field in fields)
                            {
                                if (field.GetValue(@class) is bool fieldValue)
                                {
                                    field.SetValue(@class, !fieldValue);
                                }
                            }
                        }

                        break;
                }
            }
        }
    }
}