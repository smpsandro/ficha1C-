
using System.ComponentModel;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade=10;
            
            Console.WriteLine("idade=" + idade);
            int num1 = 10;
            int num2 = 20;
            int result = num1 + num2;
            Console.WriteLine("resultado=" + result);
            Console.WriteLine("numero1=" + num1);
            Console.WriteLine("numero2=" + num2);
           //comentário uma só linha

            /*
             * comentarios várias linhas!
             * 
             * 
             * */

             //atenção ao  "$"
            Console.WriteLine($"a soma de {num1}  com {num2} é {result}");


            //Float
            float peso = 54.5f;
            double peso2 = 55.4;
            Console.WriteLine($"o peso é {peso} o peso2 é{peso2} ");


            int a = 1;
            float b = 1.4f;
            double c = 155;
            string str = "isto é uma string";
            char d = 'a';
            bool isTrue =true;
            bool isFalse =false;

            //Aula 2
            int num4 = 10;
            num4++;
            num4--;
            num4 += 2;
            Console.WriteLine($"o num4 :   {num4} ");


            Console.WriteLine("escreve um numero");
            string num1str = Console.ReadLine();
            int num6 = Convert.ToInt32(num1str);

            Console.WriteLine("escreve um numero");
            string num2str = Console.ReadLine();
            int num7 = Convert.ToInt32(num2str);

            var result2 = num6 + num7;
            Console.WriteLine($" num6 {num6} + num7 {num7} = {result2}  ");


/*Declarar funções 
 * tipo de dados ()
 * 
 * 
 * 
 * /*/
             int pedirNumero()
            {
                Console.WriteLine("escreve um numero");
                string num1str = Console.ReadLine();
                int num1 = Convert.ToInt32(num1str);
                return num1;
            }
           
            //forma de guardar o resultado da função assim que a chamamos
            //Neste caso guarda o valor na variavel num8
            int num8=pedirNumero();
            int num9 = pedirNumero();
            int somar2=num8+num9;
            Console.WriteLine($"o valor guardado na variavel num8 é:{num8} ");
            Console.WriteLine($"o valor guardado na variavel num9 é:{num9} ");
            Console.WriteLine($"a soma dos dois é :{somar2} ");

            static int soma3(int num8, int num9)
            { 
            var result2 = num8 + num9;
                return result2;

            }
            Console.WriteLine($"o return :{result2} ");// return não está a funcionar corretamente

        }
        
    }
}
