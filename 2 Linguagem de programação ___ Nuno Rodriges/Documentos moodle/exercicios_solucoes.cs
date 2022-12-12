using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //EX 1
            //ex1();
            //EX 2
            //ex2();
            //EX 3
            //ex3();
            //EX 4
            //ex4();
            //EX 5
            //ex5();
            //EX 6
            //ex6();
            //EX 7
            //ex7();
            //EX 8
            //ex8();
        }

        static void ex1()
        {
            Console.Clear();
            Console.Write("Escreva o seu nome: ");
            var nome = Console.ReadLine();
            Console.Write("Escreva a sua idade: ");
            var idade = int.Parse(Console.ReadLine());
            if (idade >= 18)
            {
                Console.WriteLine($"O condutor {nome} pode tirar a carta");
            }
            else
            {
                var anosParaCarta = 18 - idade;
                var faltaOuFaltam = (anosParaCarta == 1) ? "Falta" : "Faltam";
                Console.WriteLine($"{faltaOuFaltam} {anosParaCarta} anos para o codutor {nome} poder tirar a carta");
            }
        }

        static void ex2()
        {
            Console.Clear();
            int num1, num2, num3;
            Console.Write("Insira o numero 1: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Insira o numero 2: ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("Insira o numero 3: ");
            num3 = int.Parse(Console.ReadLine());

            if(num1 > num2)
            {
                if(num1 > num3)
                {
                    Console.WriteLine($"{num1} é maior que {num2} e {num3}");
                } else
                {
                    Console.WriteLine($"{num3} é maior que {num1} e {num2}");
                }
            } 
            else
            {
                if(num2 > num3)
                {
                    Console.WriteLine($"{num2} é maior que {num1} e {num3}");
                }
                else
                {
                    Console.WriteLine($"{num3} é maior que {num1} e {num2}");
                }
            }
        }

        static void ex3()
        {
            Console.Clear();
            float num1, num2, num3;
            Console.Write("Insira o lado 1: ");
            num1 = float.Parse(Console.ReadLine());
            Console.Write("Insira o lado 2: ");
            num2 = float.Parse(Console.ReadLine());
            Console.Write("Insira o lado 3: ");
            num3 = float.Parse(Console.ReadLine());

            if(num1 <= 0 || num2 <= 0 || num3 <= 0)
            {
                Console.WriteLine("Triangulo inválido");
                return;
            }

            if(num1 == num2 && num1 == num3)
            {
                Console.WriteLine("Triangulo Equilátero");
            } else if(num1 == num2 || num1 == num3 || num2 == num3)
            {
                Console.WriteLine("Triangulo Isosceles");
            } else
            {
                Console.WriteLine("Triangulo Escaleno");
            }
        }

        static void ex4()
        {
            Console.Clear();
            Console.Write("Insira a temperatura em F: ");
            var temperaturaF = float.Parse(Console.ReadLine());
            var celsius = (temperaturaF - 32) / 1.8;
            Console.WriteLine($"A temperatura em C é: {ce lsius}");
        }

        static void ex5()
        {
            Console.Clear();
            Console.Write("Insira o lado: ");
            var lado = float.Parse(Console.ReadLine());
            Console.Write("Insira o comprimento: ");
            var comprimento = float.Parse(Console.ReadLine());
            var area = lado * comprimento;
            Console.WriteLine($"A area do rectangulo é: {area}");
        }

        static void ex6()
        {
            Console.Clear();
            //IGUAL AO DA AULA PASSADA
        }

        static void ex7()
        {
            Console.Clear();
            Console.Write("Insira uma idade: ");
            var idade = int.Parse(Console.ReadLine());
            if(idade < 16)
            {
                Console.WriteLine("Nao pode votar");
            } else if(idade == 16 || idade == 17 || idade > 70)
            {
                Console.WriteLine("Voto facultativo");
            } else
            {
                Console.WriteLine("Voto obrigatório");
            }
        }

        static void ex8()
        {
            Console.Clear();
            Console.Write("Insira o dia de aniversário: ");
            var dia = int.Parse(Console.ReadLine());
            if(dia < 0 || dia > 31)
            {
                Console.WriteLine("Data inválida");
            }

            else
            {
                Console.Write("Insira o mes: ");
                var mes = int.Parse(Console.ReadLine());
                switch (mes)
                {
                    case 0:
                    case 1:
                    case 2:
                        //CASO ESPECIAL QUE NAO VALIDEI :) 
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        Console.WriteLine("Data válida");
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        if(dia > 30)
                        {
                            Console.WriteLine("Data inválida");
                        } else
                        {
                            Console.WriteLine("Data válida");
                        }
                        break;
                    default:
                        Console.WriteLine("Data inválida");
                        break;
                }
            }
            
        }
    }
}
