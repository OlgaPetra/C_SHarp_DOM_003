Console.Clear();
// Задача 19:Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.

//вариант первый
// Console.Write("Введите пятизначное число: ");
// int num =Convert.ToInt32(Console.ReadLine());
// while (Math.Abs(num)< 10000  && num < 99999)
// {
// Console.Write("Введенное число не пятизначное, исправьте: ");
// int num2=Convert.ToInt32(Console.ReadLine());

// if(Math.Abs(num2) > 9999 && num2 < 100000)
//     {
//     num=num2;
//     }
// }
// if (num/10000==num%10 && num/1000%10==num/10%10)
// {
// Console.WriteLine($"Число {num} является палиндромом");
// }
// else
// {
// Console.WriteLine($"Число {num} не является палиндромом");
// }

//второй вариант с использованием массива
// Console.Write("Введите пятизначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// char[]array = Math.Abs(num).ToString().ToCharArray();
// int index = 0;
// while (index < array.Length/2)
// {
//     if (array [index] ! = array [array.Length - index - 1])
//     {
//         Console.Write($"Число {num} НЕ является полиндромом:"); return;
//     }
//     index++;
// }
// Console.Write($"Число {num} является полиндромом:");




// Задача 21:Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.

// Console.Write("Введите X1: ");
// int x1=int.Parse(Console.ReadLine());
// Console.Write("Введите Y1: ");
// int y1=int.Parse(Console.ReadLine());
// Console.Write("Введите Z1: ");
// int z1=int.Parse(Console.ReadLine());
// Console.Write("Введите X2: ");
// int x2=int.Parse(Console.ReadLine());
// Console.Write("Введите Y2: ");
// int y2=int.Parse(Console.ReadLine());
// Console.Write("Введите Z2: ");
// int z2=int.Parse(Console.ReadLine());

// double d = Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2)+ Math.Pow(z2-z1,2));

// Console.WriteLine($"d={d:f2}");

// Задача 23 Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
//первый вариант
// Console.Write("Введите число N, я выведу таблицу кубов чисел от 1 до N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int ind = 1;
// if (N>0)
// {
//     while (ind<=N)
//     {
//     Console.Write(Math.Pow(ind,3) + ", ");
//     ind=ind+1;
//     }
// }
// else
// {
//     while (ind>=N)
//     {
//     Console.Write(Math.Pow(ind,3) + ", ");
//     ind=ind-1;
//     }
// }

//второй вариант -не выводит отрицательные числа, т.к.берем по модулю
// Console.Write("Введите число N, я выведу таблицу кубов чисел от 1 до N: ");
// int num = int.Parse(Console.ReadLine() ?? " 0 ");
// int count = 1;
// while (count <= Math.Abs(num))
// {
// Console.Write($"|{Math.Pow(count++, 3)}| ");
// }
