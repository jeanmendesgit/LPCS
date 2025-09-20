int healthPointsMax = 100;
int healthPoints = healthPointsMax;

int first_hit = 10;
int second_hit = 30;

Console.WriteLine($"Vida: {healthPoints}/{healthPointsMax}");
Console.WriteLine($"Primeiro Ataque! Dano: -{first_hit}");
healthPoints -= first_hit;
Console.WriteLine($"Vida: {healthPoints}/{healthPointsMax}");
Console.WriteLine($"Segundo Ataque! Dano: -{second_hit}");
healthPoints -= second_hit;
Console.WriteLine($"Vida: {healthPoints}/{healthPointsMax}");

