// y=sin(x–0,5)/(ln(x5–3)–3*102), x=2,
double x = 2.1;

double y = Math.Sin(x - 0.5) / (Math.Log(x * 5 - 3) - 3 * 102);

Console.WriteLine("y= " + y);