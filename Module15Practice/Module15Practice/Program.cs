using System;
using System.Reflection;

class MyClass
{
    private int privateField = 10;
    public string PublicProperty { get; set; }
    public int PublicMethod(int value)
    {
        return value * 2;
    }

    private void PrivateMethod()
    {
        Console.WriteLine("This is a private method.");
    }

    public MyClass(string value)
    {
        PublicProperty = value;
    }

    public MyClass()
    {
    }
}

class Program
{
    static void Main()
    {
        Type myType = typeof(MyClass);

        Console.WriteLine($"Class Name: {myType.Name}");

        Console.WriteLine("\nConstructors:");
        ConstructorInfo[] constructors = myType.GetConstructors();
        foreach (var constructor in constructors)
        {
            Console.WriteLine($"- {constructor}");
        }

        Console.WriteLine("\nFields and Properties:");
        FieldInfo[] fields = myType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
        PropertyInfo[] properties = myType.GetProperties(BindingFlags.Public | BindingFlags.Instance);
        foreach (var field in fields)
        {
            Console.WriteLine($"- Field: {field.Name}, Type: {field.FieldType}, Modifier: {field.Attributes}");
        }
        foreach (var prop in properties)
        {
            Console.WriteLine($"- Property: {prop.Name}, Type: {prop.PropertyType}, Modifier: {prop.Attributes}");
        }

        Console.WriteLine("\nMethods:");
        MethodInfo[] methods = myType.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
        foreach (var method in methods)
        {
            Console.WriteLine($"- Method: {method.Name}, Return Type: {method.ReturnType}, Modifier: {method.Attributes}");
        }

        object myObject = Activator.CreateInstance(myType);

        PropertyInfo property = myType.GetProperty("PublicProperty");
        property.SetValue(myObject, "New Value");
        int result = (int)myType.GetMethod("PublicMethod").Invoke(myObject, new object[] { 5 });
        Console.WriteLine($"\nPublicProperty after modification: {property.GetValue(myObject)}");
        Console.WriteLine($"Result of PublicMethod: {result}");

        MethodInfo privateMethod = myType.GetMethod("PrivateMethod", BindingFlags.NonPublic | BindingFlags.Instance);
        privateMethod.Invoke(myObject, null);
    }
}
