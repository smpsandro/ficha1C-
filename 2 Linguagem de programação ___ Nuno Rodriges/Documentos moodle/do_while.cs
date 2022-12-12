using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            char genero;
            int contadorM = 0, contadorF = 0, contadorO = 0, 
                contador1016 = 0, contador1624 = 0;

            do
            {
                Console.WriteLine();
                Console.WriteLine("Novo visitante ---- Terminar com Z");
                genero = Console.ReadKey().KeyChar;
                //genero = Convert.ToChar(Console.ReadLine());
                //genero = char.Parse(Console.ReadLine());

                switch (genero)
                {
                    case 'M':
                    case 'm':
                        contadorM++;
                        break;

                    case 'F':
                    case 'f':
                        contadorF++;
                        break;

                    case 'O':
                    case 'o':
                        contadorO++;
                        break;
                }

                Console.WriteLine();
                Console.WriteLine("Escreve a sua idade: ");
                int aux = int.Parse(Console.ReadLine());

                if(aux >= 10 && aux <= 16)
                {
                    contador1016++;
                } else if(aux >= 16 && aux <= 24)
                {
                    contador1624++;
                }

            } while (genero != 'Z' && genero != 'z');

            Console.WriteLine($"Mas: {contadorM}, Fem: {contadorF}, Outros: {contadorO}");
            Console.WriteLine($"Idade 10 a 16: {contador1016}, Idade 16 a 24: {contador1624}");

        }
    }
}
