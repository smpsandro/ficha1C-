using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "";
            int idade = 0;

            while (!(nome == "sair" && idade == 99))
            //while(nome != "sair" || idade != 99)
            {
                Console.WriteLine("Insira o seu nome:");
                nome = Console.ReadLine();

                Console.WriteLine("Insira a idade:");
                idade = int.Parse(Console.ReadLine());

                if (idade >= 11 && idade <= 15)
                {
                    Console.WriteLine($"O atleta {nome} com a idade {idade} pertence ao escalao juvenil");
                }
                else if (idade >= 16 && idade <= 20)
                {
                    Console.WriteLine($"O atleta {nome} com a idade {idade} pertence ao escalao junior");
                }
                else if (idade >= 21 && idade <= 25)
                {
                    Console.WriteLine($"O atleta {nome} com a idade {idade} pertence ao escalao profissional");
                }
                else
                {
                    Console.WriteLine("Categoria nao prevista");
                }
            }
        }
    }
}
