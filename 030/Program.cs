int a, b, p = 1;
Console.WriteLine("Введите число a:");
a = Convert.ToInt32(Console.ReadLine());
 
Console.WriteLine("Введите число b:");
b = Convert.ToInt32(Console.ReadLine());
 
for (int i = a; i <= b; i++) {
    p *= i;
}
 
Console.WriteLine("Произведение: " + p);
Console.Read();