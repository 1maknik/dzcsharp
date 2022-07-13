//С клавиатуры вводится целое число. Вывести квадрат числа
double a;
double b;
string? s;
s=Console.ReadLine();
a=Convert.ToDouble(s);
b=a*a;
System.Console.WriteLine($"{a}^2={b}");
