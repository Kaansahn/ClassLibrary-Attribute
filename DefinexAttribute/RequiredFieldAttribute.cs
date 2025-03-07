using System;
using System.Reflection;

namespace DefinexAttribute;

[AttributeUsage(AttributeTargets.Field, AllowMultiple = true, Inherited = true)]
public class RequiredFieldAttribute : Attribute
{
    public static bool IsValid(object entity)
    {
        Type type = entity.GetType();
        FieldInfo[] validTypeFields = type.GetFields(BindingFlags.Public | BindingFlags.Instance);

        foreach(FieldInfo validTypeField in validTypeFields)
        {
            object[] isValidAttributions = validTypeField.GetCustomAttributes(typeof(RequiredFieldAttribute), true);

            if(isValidAttributions.Length != 0)
            {
                string fieldValue = validTypeField.GetValue(entity) as string;
                if(string.IsNullOrEmpty(fieldValue)) return false;
            }
        }
        return true;
    }
}
