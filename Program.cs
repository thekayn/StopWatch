using System.Threading;

//iniciando o metodo menu
Menu();

//metodo de menu
static void Menu()
{
    //===========================passagem de informacao para o usuario===========================
    Console.Clear();
    Console.WriteLine("StopWatch em Csharp");
    Console.WriteLine("Digite S = segundo");
    Console.WriteLine("Digite M = Minuto");
    Console.WriteLine("Digite 0 = Sair da aplicacao");
    Console.WriteLine("Quanto tempo deseja contar?");

    //===================inicializacao dads variaveis====================

    //usuario escrevendo (ele escreve em string)
    string data = Console.ReadLine().ToLower();

    //pegar o ultimo charactere para saber qual tipo de dados, se vai ser minuto ou segundo
    char type = char.Parse(data.Substring(data.Length - 1, 1));

    //pegar as primeiras variaveis, no caso o tempo passado
    int time = int.Parse(data.Substring(0, data.Length - 1));

    //base de tempo de 1segundos
    int multiplier = 1;

    //==================================inicializacao das logicas de controle==================================
    if (type == 'm')
        multiplier = 60;

    if (time == 0)
        System.Environment.Exit(0);

    //=======================fazendo um 'to go' para uma outra funcao================================

    //iniciando o metodo prestart
    PreStart(time * multiplier);
}

//metodo de prestart
static void PreStart(int time)
{
    Console.Clear();
    Console.WriteLine("Ready...");
    Thread.Sleep(1000);
    Console.WriteLine("Set...");
    Thread.Sleep(1000);
    Console.WriteLine("Go...");
    Thread.Sleep(2500);

    //iniciando o metodo start
    Start(time);
}


//metodo de iniciacao com while
static void Start(int time)
{
    int currentTime = 0;

    while (currentTime != time)
    {
        Console.Clear();
        currentTime++;

        Console.WriteLine($"Contagem: {currentTime}");
        Thread.Sleep(1000);
    }
    Console.Clear();
    Console.WriteLine("StopWatch finalizado");
    Thread.Sleep(2500);
}



