using System;

class MainClass {
  public static double getAverage(double[] data)
  {
    double r = 0;
    for (int x = 0; x < data.Length; x++)
    {
      r += data[x];
    }
    return(r / data.Length);
  }
  public static void Main (string[] args) {
    double[] cTemps = new double[7];
    double[] fTemps = new double[7];
    for (int x = 0; x < 7; x++)
    {
      Console.Write("Enter The Temperature In Celsius: ");
      double t = double.Parse(Console.ReadLine());
      cTemps[x] = t;
      fTemps[x] = (t * 9/5) + 32;
    }
    Console.WriteLine("Temperatures In Fahrenheit:");
    for (int x = 6; x >= 0; x--)
    {
      Console.WriteLine(fTemps[x]);
    }
    Console.WriteLine("Average Weekly Temperature Is " + getAverage(fTemps) + " Degrees Fahrenheit");
  }
}