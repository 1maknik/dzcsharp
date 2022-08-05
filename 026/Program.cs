Console.WriteLine("Введите а: ");
            int a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите b: ");
            int b = Convert.ToInt16(Console.ReadLine());
 
            int sum = 0;
 
            if (a > b)
            {
                Console.WriteLine("Число а больше числа b");                
            }
            for (int i = a; i<= b; i++)
            {
                sum += i;
            }
            Console.WriteLine("Сумма чисел от " + a + " до " + b + ": " + sum);