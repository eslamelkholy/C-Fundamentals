
int x = 1000000;
int y = 0;



try
{
  if (x > 1000)
  {
    throw new ArgumentOutOfRangeException("X Has to be Less Than 1000");
  }
  int result = x / y;
  Console.WriteLine("The Result = ", result);
}
catch (DivideByZeroException e)
{

  Console.WriteLine("Number Cannot be Divided by Zero");
  Console.WriteLine(e.Message);
}
catch (ArgumentOutOfRangeException e)
{
  Console.WriteLine("Number Cannot be Divided by Zero");
  Console.WriteLine(e.Message);
}