Console.WriteLine("Exercicio 1\n");

Console.WriteLine("Informe um numero : ");
var numeroInformado = Convert.ToInt32(Console.ReadLine());

int[] fibo = new int[numeroInformado];
var numeroAnterior = 0;
var numeroAtual = 1;


for (int i = 0; i < numeroInformado; i++)
{
    if (i == 0)
    {
        fibo[i] = 0;
    }
    else
    {
        fibo[i] = numeroAnterior + numeroAtual;
    }

    numeroAnterior = numeroAtual;
    numeroAtual = fibo[i];
}

foreach (int num in fibo)
{
    Console.Write($"{num}  ");
}

Console.WriteLine("\n");

if (fibo.Contains(numeroInformado))
{
    Console.WriteLine($"O numero {numeroInformado} esta na lista");
}
else
{
    Console.WriteLine($"O numero {numeroInformado} NAO esta na lista");
}


Console.ReadKey();
