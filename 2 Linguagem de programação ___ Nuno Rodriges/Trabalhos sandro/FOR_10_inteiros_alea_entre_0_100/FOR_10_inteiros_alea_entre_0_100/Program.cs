// See https://aka.ms/new-console-template for more information


int numvezes = 10, num;
Random Random = new Random();

for (int i = 0; i < numvezes; i++)
{

    num = Random.Next(0, 100);

    Console.WriteLine(num);

}



Console.WriteLine("Fim ciclo!");
