const int ALLOWED_AGE = 18;

Console.WriteLine("Hello Enter your Age");
string? userAge = Console.ReadLine();

int age = -1;

if (int.TryParse(userAge, out age) && age > ALLOWED_AGE)
{
  Console.WriteLine("Welcomeeeee!");
}
else
{
  Console.WriteLine("Sorry Greater than 18 only allowed here");
}