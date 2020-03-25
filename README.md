# Primeiro

Fazendo raiz quadrada e exponencial 

    
            double x = 4;
            Console.WriteLine("Raiz quadrada do valor inserido é "+ Math.Sqrt (x));
            Console.WriteLine ("Exponecial do valaor "+ Math.Pow(Math.Sqrt(x),3));



### segundo 

            calculadora soma e substração 

             double x = 4;
            int y = 2;
            Console.WriteLine("Raiz quadrada do valor inserido é "+ (x+y));
            Console.WriteLine("Raiz quadrada do valor inserido é "+ (x-y));

### Terceira aula (Calculadora por etapa )

    Exercicio de fazer Calaculadora e salvar por etapa

    1- Foi feito a solicitação de entrada de dois valores para que os valores seja adcioandos!

        Double x = 0;
           Double y = 0;

        Console.WriteLine ("Digite o valor do primeiro  número: " );
        x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine ("Digite o valor do primeiro  número: " );
        y = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Raiz quadrada do valor inserido é "+ (x+y));
        Console.ReadLine();
    2- Coloquei as condicões para que as operações fosse feitas 

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

            Console.WriteLine("Raiz quadrada do valor inserido é "+ (x+y));
         }

         else if{

             Console.WriteLine("Operação não atualizada");

         }

        
        Console.ReadLine();
        }
        
    }

    3- Subtração com condições

else if(cartao == 'B'|| cartao == 'b'){

             Console.WriteLine("A substração  dos valores inserido é "+ (x-y));

         }

 3- Divisão com condições
else if(cartao == 'C'|| cartao == 'c'){

             Console.WriteLine("A Divisão  dos valores inserido é "+ (x/y));

         }

 4-Multiplicar com condições

 else if(cartao == 'D'|| cartao == 'd'){

             Console.WriteLine("A Multiplicação  dos valores inserido é "+ (x*y));

         }

