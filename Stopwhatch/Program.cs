// See https://aka.ms/new-console-template for more information

Menu();

static void Menu()
{

    Console.Clear();
    Console.WriteLine("S = Segundo => 10s = 10 segundos");
    Console.WriteLine("S = Minuto => 1m = 1 minuto");
    Console.WriteLine("0 = Sair");
    Console.WriteLine("Quanto tempo deseja contar?");

    string data = Console.ReadLine().ToLower();
    char type = char.Parse(data.Substring(data.Length - 1, 1));
    int time = int.Parse(data.Substring(0, data.Length - 1));

    PreStart(time, type);

}

static void PreStart(int time, char type)
{
    Console.Clear();
    Console.WriteLine("Ready...");
    Thread.Sleep(1000);
    Console.WriteLine("Set...");
    Thread.Sleep(1000);
    Console.WriteLine("Go...");

    Start(time, type);
}

static void Start(int time, char type)
{
    if (type == 'm')
    {
        time *= 60;
    }

    int currentTime = 0;

    while (currentTime != time)
    {
        Console.Clear();
        currentTime++;
        Console.WriteLine(currentTime);
        Thread.Sleep(1000);
    }

    Console.Clear();
    Console.WriteLine("Stopwhatch End");
    Thread.Sleep(2500);
}