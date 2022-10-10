// // Задача 1
// Console.WriteLine("Введите первое число:");
// 	int firstnumb = int.Parse(Console.ReadLine());
// 	Console.WriteLine("Введите второе число:");
// 	int secondnumb = int.Parse(Console.ReadLine());
//     int i;
//         for (i = firstnumb; i <= secondnumb; i++)
//             Console.Write(i*i*i + " ");


// Console.WriteLine("Введите число:");
// int num = int.Parse(Console.ReadLine());
//     int a = 0;
//     while (num > 0)
//     {
 
//         a = a + num % 10;
//         num = num /10 ;
 
//     }
//  Console.WriteLine(a);

Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine());
int i;
int a = 1;
for (i = 1; i <= num; i++);
    a = i * a;
    Console.Write(a);