// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Olá mundo!");
Console.WriteLine("O meu nome é Sandro");
Console.ReadLine();


// criar variaveis e chamar!
// basta alterar o testo da variavel meu texto 
var meuTexto = "texto colocado dentro da variavel";
Console.WriteLine(meuTexto);
Console.WriteLine(meuTexto);
Console.WriteLine(meuTexto);
Console.WriteLine(meuTexto);


// quais os tipos de variaveis?
/*
 * Int-> inteiro
 * Float -> Numero com virgula
 * Bool -> true ou false
 * string -> palavras
 * char -> um unico caracter
 */
//INTeiros
int data_de_nascimento = 1979;
Console.WriteLine (data_de_nascimento);

//string
string cor_favorita = "Azul";
Console.WriteLine(cor_favorita);

//float
float velocidadeF1 = 320.1f;
Console.Write(velocidadeF1);
Console.WriteLine(velocidadeF1);



//como poder alterar o tipo de uma vaiavel de string para int por exemplo?
dynamic corfavorita = "Azul";
Console.WriteLine("esta e a cor é uma strig irá ser mudada para int abaixo ");
Console.WriteLine(corfavorita);
corfavorita = 123;
Console.WriteLine("a cor favorita mudou de string para int com ocomando dynamic ");



//Ler e escrever na tela
    string nome = "";
    Console.WriteLine("Escreva o seu nome:");
    nome= Console.ReadLine();
    Console.WriteLine("O seu nome é:");
    Console.WriteLine(nome);

    nome = Console.ReadLine();



Console.WriteLine(corfavorita);

