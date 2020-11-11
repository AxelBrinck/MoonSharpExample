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

            double number;
            try
            {
                script.DoFile("Factorial.lua");
                number = script.Call(script.Globals["fact"], factorial).Number;
            }
            catch(SyntaxErrorException exception)
            {
                Console.Error.WriteLine(exception.Message);
                return 0;
            }
            
            return number;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(3));
        }
    }
}
