// See https://aka.ms/new-console-template for more information

while (codigoArtigo != 0)
{
    int codigopArtigo()
    {
    int codArtigo = 0;

    Console.WriteLine("intoduza o Código de artigo");
    codArtigo = int.Parse(Console.ReadLine());
    Console.WriteLine($"O codigo do artigo: {codArtigo}");
    return codArtigo;
    }
int quantidade()
{
    int quantidade = 0;

    Console.WriteLine("intoduza a quantidade");
    quantidade = int.Parse(Console.ReadLine());
    Console.WriteLine($"A quantidade: {quantidade}");
    return quantidade;
}

int preco()
{
    int preco = 0;

    Console.WriteLine("intoduza o preço");
    preco = int.Parse(Console.ReadLine());
    Console.WriteLine($"O preço: {preco} €");
    return preco;
}


    codigopArtigo();
    quantidade();
    preco();


}







