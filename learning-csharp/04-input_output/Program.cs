// Programa que soma dois números Dados definitos pelo usuario

// Entrada de Dados
Console.Write("Digite o 1° número: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o 2° número: ");
int number2 = Convert.ToInt32(Console.ReadLine());

// Processamento de Dados
int sum = number1 + number2;

// Saída de Dados
Console.WriteLine($"\nA soma de {number1} e {number2} é igual a {sum}.\n");