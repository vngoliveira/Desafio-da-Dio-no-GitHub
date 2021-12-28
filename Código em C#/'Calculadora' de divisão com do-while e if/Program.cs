using System;

namespace Projeto_3
{
    class Program
    {
        static void Main(string[] args)
        {
           int num1, num2, div;
           Console.WriteLine("Informe o primeiro valor: ");
           num1=int.Parse(Console.ReadLine());
           do{
               Console.WriteLine("Informe o segundo valor: ");
               num2=int.Parse(Console.ReadLine());

               if(num2==0){
                   Console.WriteLine("O segundo valor deve ser diferente de zero!");
               }

            }while(num2==0);
           div=num1/num2;

           Console.WriteLine("O resultado da divisão entre o primeiro e o segundo valor é " + div);
        }
    }
}
