// See https://aka.ms/new-console-template for more information

/*Ex 1
a) Solicite o nome e a idade da pessoa, e verifique se pode tirar a carta de condução.
Se a idade for >= 18, o programa indica que pode tirar a carta.
Se a idade for < 18, deve indicar quantos anos faltam para poder tirar a carta.
 */


using System.Runtime.CompilerServices;
//cartaConducao();
//maior();
//triangulo();
//grausCelsius();
//area();
//media();
//idade();


int cartaConducao()
{

    string nome;
    int idade, faltaAnos;
    Console.WriteLine("nome por favor");
    nome = Console.ReadLine();

    Console.WriteLine("idade por favor");
    idade = int.Parse(Console.ReadLine());

    if (idade >= 18)
    {

        Console.WriteLine($"Parabens {nome} a sua idade {idade} pertmite lhe tirar a carta de conducao ");
    }
    else
    {
        faltaAnos = 18 - idade;
        Console.WriteLine($"Ola {nome} a sua idade {idade} ñao lhe pertmite tirar a carta de conducao volte daqui a {faltaAnos}");

    }
    return idade;
}





/*
 * Ex 2
            Elabore um programa em que seja inserido três números inteiros e escreve na consola qual é o maior.
*/
int maior()
{
    int num1, num2, num3, maior;
    Console.WriteLine("introduza o primeiro numero");
    num1 = int.Parse(Console.ReadLine());
    Console.WriteLine("introduza o 2 numero");
    num2 = int.Parse(Console.ReadLine());
    Console.WriteLine("introduza o 3 numero");
    num3 = int.Parse(Console.ReadLine());
    if (num1 >= num2 && num1 >= num3)
    {
        maior = num1;
        Console.WriteLine($"O numero {num1} é o maior");
    }
    else if (num2 >= num1 && num2 >= num3)
    {
        maior = num2;
        Console.WriteLine($"O numero {num2} é o maior");
    }
    else
    {
        maior = num3;
        Console.WriteLine($"O numero {num3} é o maior");
    }
    return maior;
}

/*
 Ex 3
Elabore um programa que receba as medidas dos 3 lados de um triângulo.
Apresente no ecrã se é um:
- triângulo escaleno (todos os lados diferentes);
- triângulo isósceles (dois lados iguais e um diferente);
- triângulo equilátero (todos os lados iguais).
Nota: não deve permitir a inserção do valor zero ou nº negativos.
 */
void triangulo()
{
    int lado1, lado2, lado3;
    String triangulo;
    Console.WriteLine("introduza a medida de um lado do triângulo");
    lado1 = int.Parse(Console.ReadLine());
    Console.WriteLine("introduza a medida do 2 lado do triângulo");
    lado2 = int.Parse(Console.ReadLine());
    Console.WriteLine("introduza a medida do 3 lado do triângulo");
    lado3 = int.Parse(Console.ReadLine());

   
    if(lado1 >0 && lado2 >0 && lado3 > 0)
    { 
    if (lado1 != lado2 && lado1 != lado3 && lado2 != lado3)
    {
   
        Console.WriteLine("o seu triangulo e escaleno  (todos os lados diferentes) ");
    }
    else if (lado1 == lado2 && lado1 != lado3 || lado1 == lado3 && lado1 != lado2 || lado1 != lado2 && lado2 == lado3)
    {
        Console.WriteLine("o seu triangulo e isosceles 2 (dois lados iguais e um diferente)");
 
    }

    else
    {
        Console.WriteLine("triângulo equilátero (todos os lados iguais)");
    }
}
}

/*
 Ex 4
Elabore um programa que converta graus Fahrenheit em Celsius.
Ajuda: C = (F-32)/1,8

 */
void grausCelsius()
{ 
float f, c;
Console.WriteLine("introduza os graus em Fahrenheit");
f = float.Parse(Console.ReadLine());
c = (float)((float)(f - 32) /1.8);
Console.WriteLine($"os graus Fahrenheit {f} em  Celsius = {c}");
return;
}

/*
 *Ex 5
Elabore um programa que solicite a inserção de dois valores 
correspondentes ao comprimento e à altura de um retângulo 
e apresente a área respetiva. 
 */
void area()
{ 
float c, a, area;
Console.WriteLine("introduza o comprimento");
c = float.Parse(Console.ReadLine());
Console.WriteLine("introduza a altura");
a = float.Parse(Console.ReadLine());
area = c * a;
Console.WriteLine($"A area do retangulo e {area}");
return;
}

/*
 Ex 6
Calcular a média das duas notas de um aluno.
A primeira nota for igual ou superior a 5.5 e a segunda nota for igual ou superior a 8.5, 
e baseada na sua média resultar a nota superior ou igual a 7.0, o aluno está aprovado, caso contrário está reprovado!
 
 */

void media()

{ 
float nota1, nota2, media;
Console.WriteLine("introduza a nota1");
nota1 = float.Parse(Console.ReadLine());
Console.WriteLine("introduza a nota2");
nota2 = float.Parse(Console.ReadLine());


media = (nota1 + nota2)/2;

    if (nota1 >= 5.5 && nota2 >= 8.5 && media>=7)
    {
        Console.WriteLine($"Aprovado nota 1= {nota1} nota 2= {nota2} a sua media : {media}");
    }
    else
    {

        Console.WriteLine($"REPROVADO nota 1= {nota1} nota 2= {nota2} a sua media : {media}");
    }
    return;
}


/*
 Ex 7
A partir da idade informada de um cidadão, 
diga se ele não pode votar (idade inferior a 16), 
ou se o voto é facultativo (idade igual a 16 ou 17 ou ainda maior do que 70), 
ou ainda se o voto é obrigatório para idades entre 18 e 70 (incluindo estes valores)
*/
void idade()
{ 
int idade;
Console.WriteLine("introduza a idade");
idade = int.Parse(Console.ReadLine());
if (idade<16)
{
    Console.WriteLine($"A sua idade {idade} nao lhe e permitido votar");
}
else if (idade==16 || idade==17 || idade>70)
{
    Console.WriteLine($"A sua idade {idade} o seu voto e facultativo");
}
else
{
    Console.WriteLine($"A sua idade {idade} o seu voto e obrigatorio");
}
    return;
}


/*
 Ex 8
Verifique a validade de uma data de aniversário 
(solicite apenas o do dia e do mês (em número).

Dica: meses com 30 dias: abril, junho, setembro e novembro.


int dia, mes, data;
Console.WriteLine("introduza o dia");
dia = int.Parse(Console.ReadLine());
Console.WriteLine("introduza o mes");
mes = int.Parse(Console.ReadLine());

if (mes >=1 && mes<=12) && (mes % 2 != 0) && mes==8)
        Console.WriteLine(data);

 */

