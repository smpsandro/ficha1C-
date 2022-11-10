// See https://aka.ms/new-console-template for more information

/*
Como é a sintaxe de uma função

(naobrigatorio)              (nao obrigatorio)
omitido = public
Local                            Tipo               retorno                Nome              (Parametros)


Public                           Static              Void                executar            (string teste)
 

popdemos realizar e é o mais comum
Public int calcular()
ou só
int calcular() "sabemos que será publica"
 */

using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Xml;

int calcular()
{
    int a = 2;
    int b = 3; 
    int c = a + b;





    return c;
}
Console.WriteLine($"aqui está o resultado da função calcular {calcular()}");
Console.WriteLine("");

Console.WriteLine("");
int somar()
{
    int a = 1;
    int b = 2;
    int c = a + b;
    return c;
    }


Console.WriteLine($"aqui está o resultado da função somar {somar()}");
Console.WriteLine("");
Console.WriteLine("");
// Como usar o ciclo for
int testefor()
{
    int x;
        for (x=0; x<10; x++)
    
        Console.WriteLine($"o valor de x:  {x}");

        return x; 

}
Console.WriteLine($"aqui está o resultado da função testefor {testefor()}");
Console.WriteLine("");
Console.WriteLine("");




/*
 * 
 * 
 * 
 * A equipa organizadora do concurso necessita de uma aplicação que 
 * faça as inscrições de alunos, 
 * através da recolha do  
 * ----------------------------------------------nome e nota do 11ºano a matemática. 
 * O número de alunos inscritos no concurso nunca poderá
 *ok    ----------------------------------------------- ser inferior a 5 e superior a 1O. 
 * No entanto, as inscrições terminam se 
 * ----------------------------------------------a média das notas dos alunos inscritos atingir os 18 valores, 
 * desde que cumprido o preceito do mínimo de
 * ----------------------------------------------5 alunos inscritos.
 * Caso um candidato tenha 
 * ----------------------------------------------nota inferior a 14 valores, 
 * a sua inscrição é automaticamente recusada.
 */


float osTresMelhores()
{
    float nota=0;
    string nome = "";
    int numincricao=0;
    float media=0;
    int inscritos=0;

while (numincricao < 5 && numincricao<10 && media<18)
    {


        Console.WriteLine("intruduzir nota aluno");
        nota = float.Parse(Console.ReadLine());
        Console.WriteLine($"nota aluno {nota}");
        if (nota >= 14)
        {
            Console.WriteLine("intruduzir Nome do aluno");
            nome = Console.ReadLine();
            Console.WriteLine($"nome aluno {nome}");
            Console.WriteLine($"Nota do aluno {nota} nome do aluno {nome}");

            inscritos++;
        }

        numincricao++;
        media ++;
        inscritos++;



        return nota;
    }





}

    
Console.WriteLine($"testar os tresmelhores {osTresMelhores()}");
Console.WriteLine("");
Console.WriteLine("");