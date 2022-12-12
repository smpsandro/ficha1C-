using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade;

            Console.WriteLine("Insira o seu nome:");
            nome = Console.ReadLine();

            Console.WriteLine("Insira a idade:");
            idade = int.Parse(Console.ReadLine());

            if (idade >= 11 && idade <= 15) {
                Console.WriteLine($"O atleta {nome} com a idade {idade} pertence ao escalao juvenil");
            } else if(idade >= 16 && idade <= 20)
            {
                Console.WriteLine($"O atleta {nome} com a idade {idade} pertence ao escalao junior");
            }
            else if (idade >= 21 && idade <= 25)
            {
                Console.WriteLine($"O atleta {nome} com a idade {idade} pertence ao escalao profissional");
            } else
            {
                Console.WriteLine("Categoria nao prevista");
            }

            switch (idade)
            {
                case 11:
                case 12:
                case 13:
                case 14:
                case 15:
                    //Console.WriteLine("O atleta {0} com a idade {1} pertence ao escalao juvenil", nome, idade);
                    Console.WriteLine($"O atleta {nome} com a idade {idade} pertence ao escalao juvenil");
                    break;

                case 16:
                case 17:
                case 18:
                case 19:
                case 20:
                    Console.WriteLine($"O atleta {nome} com a idade {idade} pertence ao escalao junior");
                    break;

                case 21:
                case 22:
                case 23:
                case 24:
                case 25:
                    Console.WriteLine($"O atleta {nome} com a idade {idade} pertence ao escalao profissional");
                    break;

                default:
                    Console.WriteLine("Categoria nao prevista");
                    break;
            }
        }
    }
}
