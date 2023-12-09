// Даны вещественные числа a и b. Определите, принадлежит ли точка с координатами (a; b) заштрихованной области;

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

class work_4_6
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите число a: "); 
            
        float numA = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Введите число b: "); 
            
        float numB = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
        if (( ((numB - 2) / 2.5f) <= numA && ((numB - 2) / -2.5f) >= numA ) && (numB >= -3 && numB <= 2)) 
        {
            Console.WriteLine("Точка входит в эту область");
        }
        else
        {
            Console.WriteLine("Точка не входит в эту область");
        }
    }
}  
 
