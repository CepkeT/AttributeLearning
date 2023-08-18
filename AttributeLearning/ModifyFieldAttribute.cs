namespace AttributeLearning;

[AttributeUsage(AttributeTargets.Field | AttributeTargets.Class, AllowMultiple = true)]
internal class TaskModifyFieldAttribute : Attribute
{
    public Type? TargetType { get; set; } = null;
    public object? TargetModificationValue { get; set; } = null;
    
   
}