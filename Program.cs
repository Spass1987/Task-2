//Задача №2. Напишите программу, которая на вход принимает два числа и выдает, 
//какое число больше, а какое меньше. 
//Пример: 
//а = 5; b = 7 -> max =7
//а = 2; b = 10 -> max = 10
//а = -9; b = -3 -> max = -3
Console.Write("Введите первое число");
int maxnumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число");
int minnumber = Convert.ToInt32(Console.ReadLine());

if (maxnumber == minnumber * minnumber)

    Console.WriteLine("Первое число больше второго");

else

    Console.WriteLine("Второе число больше первого");

