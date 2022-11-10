// See https://aka.ms/new-console-template for more information
char genero = '';
int idade, contadorFeminino = 0, contadorMasculino = 0, contadorIdade10a16 = 0, contadoridade16a24 = 0;


do
{
    Console.WriteLine("Novo visitante ---- terminar com caracter z");
    genero = char.Parse(Console.ReadLine());

        if (genero == m || genero == M)
    {
            contadorMasculino++;
    }

    
} while (genero != 'z'&& genero !='Z');





Console.WriteLine($"- Feminino: {contadorFeminino} - Masculino: {contadorMasculino} - Idade10a16: {contadorIdade10a16} - idade16a24: {contadoridade16a24}");
