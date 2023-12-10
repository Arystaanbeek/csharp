using System;
using System.Collections.Generic;
using System.Reflection;

class MyClass
{
    public int Number { get; set; }
    public string Text { get; set; }
    public double Value { get; set; }
}

class Program
{
    static void Main()
    {
        Type consoleType = typeof(Console);
        MethodInfo[] methods = consoleType.GetMethods();

        Console.WriteLine("Methods of the Console class:");
        foreach (var method in methods)
        {
            Console.WriteLine(method.Name);
        }
        Console.WriteLine();

        MyClass myObject = new MyClass
        {
            Number = 10,
            Text = "Hello, Reflection!",
            Value = 3.14
        };

        Type myType = myObject.GetType();
        PropertyInfo[] properties = myType.GetProperties();

        Console.WriteLine("Properties of the MyClass class and their values:");
        foreach (var prop in properties)
        {
            object value = prop.GetValue(myObject);
            Console.WriteLine($"{prop.Name}: {value}");
        }
        Console.WriteLine();

        string text = "This is a test string";
        Type stringType = typeof(string);
        MethodInfo substringMethod = stringType.GetMethod("Substring", new Type[] { typeof(int), typeof(int) });

        if (substringMethod != null)
        {
            object[] parameters = new object[] { 5, 7 };
            object result = substringMethod.Invoke(text, parameters);
            Console.WriteLine("Result of calling Substring: " + result);
        }
        Console.WriteLine();

        Type listType = typeof(List<>);
        Type[] typeArgs = { typeof(int) };

        Type constructedType = listType.MakeGenericType(typeArgs);
        ConstructorInfo[] constructors = constructedType.GetConstructors();

        Console.WriteLine("Constructors of the List<T> class:");
        foreach (var constructor in constructors)
        {
            Console.WriteLine("Constructor: " + constructor);
        }
    }
}
