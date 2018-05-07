using System;
using System.Reflection;
using Chapter2.Reflections.CalculatorLib;


namespace Chapter2.Reflections.ReflectCore
{
    class Program
    {
        static void Main(string[] args)
        {
            MemberInfo info = typeof(Calculator);

            Console.WriteLine($"Assembly Name: {info.Name}");
            Console.WriteLine($"Module Name: {info.Module.Name}");
            Console.WriteLine();

            var calculator = new Calculator();
            var typeObject = calculator.GetType();

            var methods = typeObject.GetRuntimeMethods();

            foreach (var method in methods)
            {
                Console.WriteLine($"Method name : {method.Name}, ---> Return type : {method.ReturnType}");
            }



            Console.ReadLine();
        }
    }
}
