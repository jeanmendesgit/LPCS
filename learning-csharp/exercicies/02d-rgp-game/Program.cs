string playerName = "Lord Jean";
float playerHeight = 1.63f;
int playerForce = 97;
int playerAgility = 98;
int playerIntelligence = 99;
bool playerClassChoose = false;
string playerClass = "";

if (playerClassChoose)
{
    playerClass = "Herói";
}
else
{
    playerClass = "Vilão";
}

Console.WriteLine("-------------------------");
Console.WriteLine("         RPG GAME        ");
Console.WriteLine("-------------------------");
Console.WriteLine(" ");
Console.WriteLine("Ficha de Personagem:");
Console.WriteLine($"> Nome: {playerName}");
Console.WriteLine($"> Altura: {playerHeight}");
Console.WriteLine($"> Força: {playerForce}");
Console.WriteLine($"> Agilidade: {playerAgility}");
Console.WriteLine($"> Inteligência: {playerIntelligence}");
Console.WriteLine($"> Classe: {playerClass}");