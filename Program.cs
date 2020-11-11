using System;
using System.IO;
using MoonSharp.Interpreter;

namespace MoonSharpExample
{
    class Program
    {
        static double Factorial(int factorial)
        {
            Script script = new Script();
            script.Globals["factorial"] = factorial;

            DynValue value;
            try
            {
                value = script.DoFile("Factorial.lua");
            }
            catch(SyntaxErrorException exception)
            {
                Console.Error.WriteLine(exception.Message);
                return 0;
            }
            
            return value.Number;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(5));
        }
    }
}
