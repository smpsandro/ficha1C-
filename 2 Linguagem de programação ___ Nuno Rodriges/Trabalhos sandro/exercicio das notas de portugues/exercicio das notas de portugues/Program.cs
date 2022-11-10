// See https://aka.ms/new-console-template for more information
using System;
using System.Net.Security;

float nota1, nota2, notafinal;
string nome;

Console.WriteLine("introduza o seu nome");
nome = Console.ReadLine();


Console.WriteLine($"Olá, {nome}, vamos verificar se nos vemos para o ano?");

Console.WriteLine("Introduza a sua primeira Nota");
nota1 = float.Parse(Console.ReadLine());
Console.WriteLine($"{nome}, a sua 1 nota foi:{nota1}, podia ter estudado muito mais!");
Console.WriteLine("Introduza a sua segunda Nota");
nota2 = float.Parse(Console.ReadLine());
Console.WriteLine($"{nome}, a sua 2 nota foi:{nota2}, lol !");

if
    (nota1>=8.5 && nota2>=9)
{


    notafinal = (nota1 + nota2) / 2;
    
        
        Console.WriteLine($"aprovado, a sua nota final foi: {notafinal} ");
    if (notafinal >= 17)
    {
        Console.WriteLine($"aprovado, a sua nota final foi: {notafinal} e está inscrito para oral");
    }
}
     else
{ 
        Console.WriteLine("Reprovado, até para o ano!!! GAMEOVER!!!");
}


