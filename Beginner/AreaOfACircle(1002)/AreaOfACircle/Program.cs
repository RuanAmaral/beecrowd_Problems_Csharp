// See https://aka.ms/new-console-template for more information
double r = 0.0, pi = 3.14159;
decimal a = 0;
r = Convert.ToDouble(Console.ReadLine());
a = Math.Round(Convert.ToDecimal(pi * (r * r)), 4);
var s = Decimal.ToOACurrency(a).ToString();
if (s.Substring(s.Length - 1, 1) == "0")
{
    Console.WriteLine("A=" + a + "0");
}
else
{
    Console.WriteLine("A=" + a);
}




