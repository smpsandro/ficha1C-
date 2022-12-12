using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, notafinal;
            string nome;
            Console.Write("Insira nome: ");
            nome = Console.ReadLine();
            Console.Write("Insira nota 1: ");
            nota1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Insira nota 2: ");
            nota2 = Convert.ToDouble(Console.ReadLine());

            if (nota1 <= 9.5 && nota2 <= 8.5)
            {
                notafinal = (nota1 + nota2) / 2;
                if(notafinal >= 10 && notafinal < 17)
                {
                    Console.WriteLine($"A nota do aluno {nome} é: {notafinal}");
                } 
                else if(notafinal >= 17)
                {
                    Console.Write("Introduza a nota final com oral: ");
                    notafinal = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"A nota do aluno {nome} é: {notafinal}");
                }
                else
                {
                    Console.WriteLine($"O aluno {nome} está REPROVADO");
                }
            }
            else 
            {
                Console.WriteLine($"O aluno {nome} está REPROVADO");
            }
        }
    }
}
