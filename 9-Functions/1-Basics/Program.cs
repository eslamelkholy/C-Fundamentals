float MilesToKm(float miles)
{
  float result = miles * 1.6f;

  return result;
}


void printMilesToKm(float miles)
{
  Console.WriteLine(MilesToKm(miles));
}


printMilesToKm(10000);
