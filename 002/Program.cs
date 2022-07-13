//С клавиатуры вводятся два вещественных числа. Проверять является ли одно из них квадратом второго
double a,b;
string? s=Console.ReadLine();
a=Convert.ToDouble(s);
s=Console.ReadLine();
b=Convert.ToDouble(s);
if (a*a==b)
{
    System.Console.WriteLine("b квадрат a");
}
else{
    System.Console.WriteLine("b не квадрат a");
}
if (a==b*b)
{
    System.Console.WriteLine("а квадрат b");
}
else{
    System.Console.WriteLine("a не квадрат b");
}