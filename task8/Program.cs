﻿//Task8
Console.Clear(); 

Console.Write("введите число:  ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 2 ; i <= n; i+=2)
     Console.Write($"{i} "); //применяем интерполяцию строк
   
