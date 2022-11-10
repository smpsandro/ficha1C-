// See https://aka.ms/new-console-template for more information
using System;








string nome = "";
int idade = 0;
//enquanto não escrever sair repete sempre o pedido
while (nome != "sair" && idade != 99)
{

    Console.WriteLine("Introduza o nome do ateleta");
    nome = Console.ReadLine();
    if (nome != "sair")
    {
        if (idade != 99)
        {

            Console.WriteLine("Introduza a idade do atleta");
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine($"Nome do atleta: {nome}");
            Console.WriteLine($"Idade do atleta: {idade}");
            switch (idade)
            {
                case 11:
                    Console.WriteLine($"Ateleta {nome} tem {idade} anos de idade");
                    Console.WriteLine($"A sua inscrição será gratuita! porque {idade} <= a 12");
                    Console.WriteLine($"A sua categoria é JUVENIL");
                    break;


                case 12:
                    Console.WriteLine($"Ateleta {nome} tem {idade} anos de idade");
                    Console.WriteLine($"A sua inscrição será gratuita! porque {idade} <= a 12");
                    Console.WriteLine($"A sua categoria é JUVENIL");
                    break;


                case 13:
                case 14:
                case 15:
                    Console.WriteLine($"Ateleta {nome} tem {idade} anos de idade");
                    Console.WriteLine($"A sua categoria é JUVENIL");
                    break;


                case 16:
                case 17:
                case 18:
                case 19:
                case 20:
                    Console.WriteLine($"Ateleta {nome} tem {idade} anos de idade");
                    Console.WriteLine($"A sua categoria é JUNIOR");
                    break;


                case 21:
                case 22:
                case 23:
                case 24:
                case 25:
                    Console.WriteLine($"Ateleta {nome} tem {idade} anos de idade");
                    Console.WriteLine($"A sua categoria é PROFISSIONAL");
                    break;

                default:
                    Console.WriteLine($"O atleta {nome} não poderá ser inscrito a sua idade não pertence ao conjunto [11;25]");
                    break;

            }
        }
    }
}
Console.WriteLine("fim");