 Console.Write("Введите x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double S = 1;
            Console.Write("Введите кол-во повторов: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                S *= x;
            }
            Console.WriteLine(S);
