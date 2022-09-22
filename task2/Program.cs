/*Напишите программу, которая выводит третью цифру заданного 
числа или сообщает, что третьей цифры нет.*/
Console.Clear();
Random rnd = new Random();
int number= rnd.Next();
Console.WriteLine(number);
string strnum = Convert.ToString(number);
if (strnum.Length > 2)
  Console.WriteLine("Третья цифра: " + strnum[2]);
else 
  Console.WriteLine("Третьей цифры нет");
