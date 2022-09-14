// Declarando variáveis e inicializando do zero.
int numero1 = 0; int numero2 = 0;

// Titulo do app.
Console.WriteLine("Calculadora\r");
Console.WriteLine("------------------------\n");

// primeiro numero da soma.
Console.WriteLine("Digite um número, e tecle Enter: ");
numero1 = Convert.ToInt32(Console.ReadLine());

// segundo numero da soma.
Console.WriteLine("Digite outro número, e tecle Enter:");
numero2 = Convert.ToInt32(Console.ReadLine());

// O usuário decide o tipo de operação
Console.WriteLine("Escola uma das operações a seguir:");
Console.WriteLine("\ta - Adição");
Console.WriteLine("\ts - Subtração");
Console.WriteLine("\tm - Multiplicação");
Console.WriteLine("\td - Divisão");
Console.Write("Qual operação? ");

// switch para trocar
switch (Console.ReadLine())
{
    case "a":
        Console.WriteLine($"Seu resultado é: {numero1} + {numero2} = " + (numero1 + numero2) + "\n");
        break;
    case "s":
        Console.WriteLine($"Seu resultado é: {numero1} - {numero2} = " + (numero1 - numero2) + "\n");
        break;
    case "m":
        Console.WriteLine($"Seu resultado é: {numero1} * {numero2} = " + (numero1 * numero2) + "\n");
        break;
    case "d":
        Console.WriteLine($"Seu resultado ét: {numero1} / {numero2} = " + (numero1 / numero2) + "\n");
        break;
}
Console.Write("Pressione alguma tecla para encerrar a Calculadora...");
Console.ReadKey();