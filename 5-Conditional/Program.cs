// const int ALLOWED_AGE = 18;

// Console.WriteLine("Hello Enter your Age");
// string? userAge = Console.ReadLine();

// int age = -1;

// if (int.TryParse(userAge, out age) && age > ALLOWED_AGE)
// {
//   Console.WriteLine("Welcomeeeee!");
// }
// else
// {
//   Console.WriteLine("Sorry Greater than 18 only allowed here");
// }


Console.WriteLine("Hello Please Enter your Role....");
string? userRole = Console.ReadLine();

switch (userRole)
{
  case "admin":
    Console.WriteLine("OH Hello Admin");
    break;
  case "user":
    Console.WriteLine("OH Hello User");
    break;

  default:
    Console.WriteLine("PLEASE Enter a Valid Role");
    break;
}
