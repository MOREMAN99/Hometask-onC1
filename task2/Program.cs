//Task 4
Console.Clear() ;
Console.Write("Введите 1-е число :");
int a = Convert.ToInt32 (Console.ReadLine()); //ввод чисел
Console.Write("Введите 2-е число: ");
int b = Convert.ToInt32 (Console.ReadLine()); //ввод чисел
Console.Write("Введите 3-е число: ");
int c = Convert.ToInt32 (Console.ReadLine()); //ввод чисел
if (a > b && a > c)
Console.WriteLine("Nubmer Max = " + a); 
 else if (b > c)
Console.WriteLine("Number Max = " + b); 
else
Console.WriteLine("Number Max = " + c); 
Console.ReadLine();