using System;
using MoonSharp.Interpreter;

namespace MoonSharpExample
{
    class Program
    {
        static double Factorial()
        {
            string script = @"    
                -- defines a factorial function
                function fact (n)
                    if (n == 0) then
                        return 1
                    else
                        return n*fact(n - 1)
                    end
                end

                return fact(6)";

            var res = Script.RunString(script);
            return res.Number;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Factorial());
        }
    }
}
