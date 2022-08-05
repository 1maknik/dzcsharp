Console.WriteLine("Введите число:");
		int firstnumb = int.Parse(Console.ReadLine());
		int firstkyb = 1;
		int i = 0;
		
		for(i=0; i<3; i++)
		{
			firstkyb *= firstnumb;
		}
		
		Console.WriteLine("Куб числа: " + firstkyb );