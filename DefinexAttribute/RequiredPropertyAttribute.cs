using System;
using System.Reflection;

namespace DefinexAttribute;

[AttributeUsage(AttributeTargets.Property, AllowMultiple = true, Inherited = true)]
public class RequiredPropertyAttribute : Attribute
{
    public static bool IsValid(object entity)
    {
        if (entity == null)
            return false;

        Type type = entity.GetType();
        PropertyInfo[] properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);

        foreach (PropertyInfo property in properties)
        {
            // Check if the property has the RequiredPropertyAttribute
            object[] attributes = property.GetCustomAttributes(typeof(RequiredPropertyAttribute), true);
            if (attributes.Length > 0)
            {
                // Get the value of the property
                object value = property.GetValue(entity);
                if (value == null || string.IsNullOrEmpty(value.ToString()))
                {
                    return false; // Validation failed
                }
            }
        }

        return true; // Validation passed
    }

}
