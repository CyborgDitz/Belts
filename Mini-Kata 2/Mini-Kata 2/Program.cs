using System.ComponentModel;

string name = "Arin";
int hp = 100;
float atkP = 30.33f;
double experiencePoints = 250;
bool isParalysed = true;
string gold = "150,333";

double hpAsDouble = hp;
int atkPAsInt = (int)atkP;
int experiencePointsAsInt = Convert.ToInt32(experiencePoints);
double goldParse = double.Parse(gold);
int shitName;

Console.WriteLine($"Health Points as double {hpAsDouble}");
Console.WriteLine($"Attack Power as int: {atkPAsInt}");
Console.WriteLine($"Experience Points as int: {experiencePointsAsInt}");
Console.WriteLine($"Gold Coins: {goldParse}");
bool doesItBlend = int.TryParse(name, out shitName);
if (doesItBlend)
{
    Console.WriteLine($"Parsed successfully: {shitName}");
}
else
{
    Console.WriteLine("Parsing failed: 'invalid' is not a number.");
}
