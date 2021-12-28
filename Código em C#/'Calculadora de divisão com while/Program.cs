using System;

namespace Projeto_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, div;
            Console.WriteLine("Informe o primeiro valor: ");
            num1=int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo valor: ");
                num2=int.Parse(Console.ReadLine());

            while(num2==0) {

                Console.WriteLine("Segundo valor deve ser diferente de zero!");

                Console.WriteLine("Informe o segundo valor: ");
                num2=int.Parse(Console.ReadLine());
            }
            div=num1/num2;
            Console.WriteLine("O resultado da divisão entre o primeiro valor e o segundo valor é " + div);
        }
    }
}
