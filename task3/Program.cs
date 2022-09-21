/*Напишите программу, которая принимает на вход цифру, обозначающую день недели,
 и проверяет, является ли этот день выходным.*/
 Console.Clear();
 Console.WriteLine("Введите число от 1 до 7:");
 int num = int.Parse(Console.ReadLine());
  if (num > 5 & num < 8)
 Console.WriteLine ("Выходной");
 else if (num < 6 & num>0)
 Console.WriteLine ("Будни");
 else 
 Console.WriteLine ("Нет такого дня недели");
 