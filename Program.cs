// int number = new Random().Next(100,1000);
// Console.Write($"заданное число: {number} ");

// int num1 = number / 10; // 
// int num2 = num1 % 10; // 

// Console.WriteLine($"Вторая цифра {num2}");

// Console.Write("Введите трёхзначное число: "); 
// int num3 = Convert.ToInt32(Console.ReadLine()!);
// int num4 = num3 / 10;
// int num5 = num4 % 10; 

// if ((num3  > 99) && (num3 < 1000))
// {
//  Console.Write($"Вторая цифра: {num5}");
//  }
//  else
//  {
// Console.Write($"Глаза разуй, написано же, что введите трёхзначное число");
//  }
// int num6 = new Random().Next(1,100000);
//  Console.Write($"заданное число: {num6} ");
 
//  if(num6 < 100)
//     {
//     Console.Write($"Третьей цифры нет");
//     }
// else

// while((num6  >= 100) && (num6 < 1000))
// {
//     int num7 = num6 % 10;
//     Console.Write($"Третья цифра: {num7}");
//     num6 = 0;
// }
// while((num6  >= 1000) && (num6 < 10000))
// {
//     int num7 = (num6 / 10) % 10;
//     Console.Write($"Третья цифра: {num7}");
//     num6 = 0;
// }
// while((num6  >= 10000) && (num6 < 100000))
// {
//     int num7 = (num6 / 100)% 10;
//     Console.Write($"Третья цифра: {num7}");
//     num6 = 0;
// }
// Console.Write("Введите день недели цифрой(понедельник - 1;вторник - 2;среда - 3; четверг - 4; пятница - 5; суббота - 6;воскресение - 7): "); 
// int date = Convert.ToInt32(Console.ReadLine()!);
// if(1 > date || date > 7) 
// {
//     Console.Write($"такого дня недели нет");
// }
// else if(1 <= date && date <= 5)
// {
//     Console.Write($"Будний день");
// }
// else if(5 < date && date <= 7)
// {
//     Console.Write($"Выходной день");
// }