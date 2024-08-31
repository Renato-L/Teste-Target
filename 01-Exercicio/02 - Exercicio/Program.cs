Console.WriteLine("Exercicio 2\n");

var contador = 0;

Console.WriteLine("Informe uma palavra :");
var palavraInformada = Console.ReadLine();

char[] palavra = palavraInformada.ToLower().ToCharArray();

foreach (char c in palavra)
{
    if (c.Equals('a'))
    {
        contador++;
    }
}

Console.WriteLine();

if (contador > 0)
{
    Console.WriteLine("A palavra informada contem a letra 'a'");
    Console.WriteLine($"A palavra {palavraInformada} contem {contador} letras 'a'");
}


Console.ReadKey();