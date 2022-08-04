//Задать массив из 8 целых элементов и вывести их на экран

//Инициализация переменных
int[] a;

//Ввод данных
Init(out a,max:100);
//Обработка данных

//Вывод результатов
Print(a);


void Init(out int[] a,int Length=10,int min=0,int max=10)
{
    a=new int[Length];
    Random random=new Random();//псевдослучайные числа
    for(int i=0;i<a.Length;i++)
            a[i]=random.Next(min,max+1);
}


void Print(int[] a)
{
    for(int i=0;i<a.Length;i++)
        System.Console.Write($"{a[i],4}");
}