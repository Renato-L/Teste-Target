Console.WriteLine("Exercicio 4\n");

int[] resultado1 = new int[5];
var numero = 0;

for (int i = 0; i < 5; i++)
{
    if (numero % 2 != 0)
    {
        resultado1[i] = numero;
    }
    else
    {
        if (resultado1[i] == 0)
        {
            i--;
        }
    }

    numero++;
}

Console.Write("a) ");

foreach (int i in resultado1)
{
    Console.Write($"{i} ");
}

Console.WriteLine("\n");
// -----------------------------------------------------------------------------

var resultado2 = new int[7];
var numero2 = 0;

for (int i = 0; i < 7; i++)
{
    if (numero2 == 0)
    {
        numero2++;
    }

    numero2 *= 2;
    resultado2[i] = numero2;
}

Console.Write("b) ");

foreach (int i in resultado2)
{
    Console.Write($"{i} ");
}

Console.WriteLine("\n");
// -----------------------------------------------------------------------------

var resultado3 = new int[8];
var numero3 = 0;
var numerosImpares = 1;

for (int i = 0; i < 8; i++)
{
    if (numero3 == 0)
    {
        resultado3[i] = numero3;
    }
    else
    {
        resultado3[i] = numero3;
    }

    numero3 += numerosImpares;
    numerosImpares += 2;

}

Console.Write("c) ");

foreach (int i in resultado3)
{
    Console.Write($"{i} ");
}

Console.WriteLine("\n");
// -----------------------------------------------------------------------------


var resultado4 = new int[5];
var numero4 = 0;
var numeroSomado = 12;

for (int i = 0; i < 5; i++)
{
    if (numero4 == 0)
    {
        numero4 += 4;
    }

    resultado4[i] = numero4;
    numero4 += numeroSomado;
    numeroSomado += 8;
}

Console.Write("d) ");

foreach (int i in resultado4)
{
    Console.Write($"{i} ");
}

Console.WriteLine("\n");
// -----------------------------------------------------------------------------

var resultado5 = new int[7];
var numeroAnterior = 0;
var numeroAtual = 1;


for (int i = 0; i < 7; i++)
{
    if (i == 0 || i == 1)
    {
        resultado5[i] = 1;
    }
    else
    {
        resultado5[i] = numeroAnterior + numeroAtual;
    }

    numeroAnterior = numeroAtual;
    numeroAtual = resultado5[i];
}

Console.Write("e) ");

foreach (int i in resultado5)
{
    Console.Write($"{i} ");
}

Console.WriteLine("\n");
// -----------------------------------------------------------------------------

Console.Write("f) O proximo numero seria o 200. Pois a logica sao os numeros que começam com a letra 'D'");


Console.ReadKey();