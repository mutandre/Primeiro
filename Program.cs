using System;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
           Double x = 0;
           Double y = 0;

        Console.WriteLine ("Digite o valor do primeiro  número: " );
        x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine ("Digite o valor do primeiro  número: " );
        y = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Raiz quadrada do valor inserido é "+ (x+y));
        Console.ReadLine();
        }
        
    }
}
