Console.WriteLine("Exercicio 5\n");

bool lampada1 = false;
bool lampada2 = false;
bool lampada3 = false;

bool lampada1Quente = false;
bool lampada3Quente = false;


// Nesse primeiro passo eu ligo a Lampada1 e deixo ela ligada por um tempo para ela aquecer
lampada1 = true;
lampada1Quente = true;

// No segundo passo eu desligo a Lampada1 e ligo a Lampada2
lampada1 = false;
lampada2 = true;


// Agora eu vou na sala das lampadas e verifico

if (lampada2)
{
    Console.WriteLine("A lampada que está acesa é a Lampada 2, que é controlada pelo interruptor que deixei ligado");
}

if (lampada1Quente && !lampada1)
{
    Console.WriteLine("A lampada que está quente, mas apagada, é a Lampada 1, controlada pelo interruptor que eu liguei e desliguei");
}

if (!lampada3 && !lampada3Quente)
{
    Console.WriteLine("A lampada que está fria e apagada é a Lampada 3, controlada pelo interruptor que eu nao utilizei");
}



Console.ReadKey();