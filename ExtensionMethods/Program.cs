using System;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //12/05/2021
            //12-05-2021
            //2021-05-12
            string bv = string.Empty;
            Console.WriteLine(bv.BoasVindas());
            Console.WriteLine($"Formato 1: {DateTime.Now.PrimeiroFormato()}");
            Console.WriteLine($"Formato 2: {DateTime.Now.SegundoFormato()}");
            Console.WriteLine($"Formato 1: {DateTime.Now.TerceiroFormato()}");

        }

    }
}
