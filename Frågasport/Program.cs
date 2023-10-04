Console.WriteLine("-- WELCOME TO THE MIGHTY BATTLE OF UCHRAL AND NANDIA --");
Console.WriteLine("WHO WILL WIN? NOBODY KNOWS...");

int nandiaHp = 100;
int uchralHp = 100;

string nandiaName = "nandia";
string uchralName = "uchral";

Random generator = new Random();

while (nandiaHp > 0 && uchralHp > 0)
{
  Console.WriteLine("-- NEW ROUND --");
  Console.WriteLine($"{nandiaName}: {nandiaHp}  {uchralName}: {uchralHp}");

  int nandiaDamage = generator.Next(20);
  uchralHp -= nandiaDamage;
  uchralHp = Math.Max(0, uchralHp);
  Console.WriteLine($"{nandiaName} does {nandiaDamage} damage to {uchralName}");

  int uchralDamage = generator.Next(20);
  nandiaHp -= uchralDamage;
  nandiaHp = Math.Max(0, nandiaHp);
  Console.WriteLine($"{uchralName} does {uchralDamage} damage to {nandiaName}");

  Console.WriteLine("CONTINUE?");
  Console.ReadKey();
}

while (nandiaHp > 0 && uchralHp > 0)
{
  Console.WriteLine("-- NEW ROUND --");
  Console.WriteLine($"{nandiaName}: {nandiaHp}  {uchralName}: {uchralHp}\n");

  int nandiaDamage = generator.Next(20);
  uchralHp -= nandiaDamage;
  uchralHp = Math.Max(0, uchralHp);
  Console.WriteLine($"{nandiaName} does {nandiaDamage} damage to {uchralName}");

  int uchralDamage = generator.Next(20);
  nandiaHp -= uchralDamage;
  nandiaHp = Math.Max(0, nandiaHp);
  Console.WriteLine($"{uchralName} does {uchralDamage} damage to {nandiaName}");

  Console.WriteLine("CONTINUE?");
  Console.ReadKey();
}
while (nandiaHp > 0 && uchralHp > 0)
{
  Console.WriteLine("-- NEW ROUND --");
  Console.WriteLine($"{nandiaName}: {nandiaHp}  {uchralName}: {uchralHp}\n");

  int nandiaDamage = generator.Next(20);
  uchralHp -= nandiaDamage;
  uchralHp = Math.Max(0, uchralHp);
  Console.WriteLine($"{nandiaName} does {nandiaDamage} damage to {uchralName}");

  int uchralDamage = generator.Next(20);
  nandiaHp -= uchralDamage;
  nandiaHp = Math.Max(0, nandiaHp);
  Console.WriteLine($"{uchralName} does {uchralDamage} damage to {nandiaName}");

  Console.WriteLine("CONTINUE?");
  Console.ReadKey();
}

Console.WriteLine("----- FIGHT IS OVER -----");

if (nandiaHp == 0 && uchralHp == 0)
{
  Console.WriteLine("DRAW");
}
else if (nandiaHp == 0)
{
  Console.WriteLine($"{uchralName} vann!");
}
else
{
  Console.WriteLine($"{nandiaName} vann!");
}

Console.WriteLine("Press any button to exit");

Console.ReadKey();