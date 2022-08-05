System.Console.WriteLine();

int dayNumber = 5;
string[] Days = { "понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье" };
string txtResult = "";

if (dayNumber > 5) txtResult = $". выходной";
else txtResult = $", рабочий ";

System.Console.WriteLine();
System.Console.WriteLine($"{dayNumber}-й день недели - это {Days[dayNumber - 1]}{txtResult}");
System.Console.WriteLine();
