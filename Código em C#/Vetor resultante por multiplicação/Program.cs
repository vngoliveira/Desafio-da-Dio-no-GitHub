using System;

namespace Projeto_10___Questão_6_da_Lista_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] vetor = new int [10];
            int [] vitor = new int [10];

            for(int e=0; e<10; e++)
            {
                Console.WriteLine("Informe um valor que será adicionado ao vetor: ");
                vetor[e]=Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Informe um valor qualquer: ");
            int num=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("O vetor resultante da multiplicação entre "+num+" e o primeiro vetor: ");
            for(int i=0; i<10; i++)
            {
              Console.WriteLine(vitor[i]=Convert.ToInt32(vetor[i]*num));   
            }
        }
    }
}
