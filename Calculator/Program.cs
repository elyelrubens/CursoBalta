// See https://aka.ms/new-console-template for more information
Console.Clear();
var calculator = new Calculator();
bool stop = false;
while (!stop)
{
    Console.WriteLine("");
    Console.WriteLine($"Resultado: {calculator.Value}");


    Console.WriteLine("Informe a opção desejada: ");
    Console.WriteLine("1: Somar");
    Console.WriteLine("2: Subtrair ");
    Console.WriteLine("3: Multiplicar");
    Console.WriteLine("4: Dividir");
    Console.WriteLine("5: Zerar ");
    Console.WriteLine("6: Sair");
    short option = short.Parse(Console.ReadLine());
    Console.WriteLine("Informe o valor: ");
    double value = Double.Parse(Console.ReadLine());
    switch (option)
    {
        case 1: calculator.Sum(value); break;
        case 2: calculator.Subtract(value); break;
        case 3: calculator.Multiply(value); break;
        case 4: calculator.Divide(value); break;
        case 5: calculator.Value = 0.00; break;
        case 6: stop = true; break;
        default: Console.WriteLine("Opção Inválida"); break;
    }
}