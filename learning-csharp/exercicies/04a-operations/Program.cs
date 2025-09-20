// Programa que realiza as operacoes basicas entre dois números

// Entrada de Dados
Console.Write("\nDigite o 1° número: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o 2° número: ");
int number2 = Convert.ToInt32(Console.ReadLine());

// Processamento de Dados
int sum = number1 + number2;
int sub = number1 - number2;
int mut = number1 * number2;
int div = number1 / number2;

// Saída de Dados
Console.WriteLine("\nOperações:");
Console.WriteLine($"> Soma: ...... {number1} + {number2} = {sum}");
Console.WriteLine($"> Subtração: . {number1} - {number2} = {sub}");
Console.WriteLine($"> Multiplição: {number1} * {number2} = {mut}");
Console.WriteLine($"> Divisão: ... {number1} / {number2} = {div}\n");
