using System;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
           Double x = 0;
           Double y = 0;
            char cartao;

        Console.WriteLine ("Digite o valor do primeiro  número: " );
        x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine ("Digite o valor do primeiro  número: " );
        y = Convert.ToDouble(Console.ReadLine());
       
        Console.WriteLine (" Digite a letra A para adicionar"+"\r\n"+
         " Digite a letra B para subtrair"+"\r\n"+ " Digite a letra C para dividir"+"\r\n"
         +" Digite a letra B para subtrair"+"\r\n");
        cartao = Convert.ToChar(Console.ReadLine());

         if (cartao == 'S'|| cartao == 's') {

            Console.WriteLine("A Soma dos valores inserido é "+ (x+y));
         }

         else if(cartao == 'B'|| cartao == 'b'){

             Console.WriteLine("A substração  dos valores inserido é "+ (x-y));

         }

        
        Console.ReadLine();
        }
        
    }
}
