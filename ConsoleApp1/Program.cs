// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic;

Console.WriteLine("program begin!");

int sum = 0;
for (int i = 0; i < 3; i++)
{ 
      
     sum += i;
     System.Console.WriteLine($"i = {i}");
     System.Console.WriteLine($"sum = {sum}");
    
     if (sum == 3)
    {
        System.Console.WriteLine($"We have the magical sum of {sum}");
    }
    System.Console.WriteLine();

    
    }


Console.WriteLine("MyLoop");

sum = 0;
for (int i = 0; i < 8; i++)
{    if (i % 2 == 1) 
     sum += i;
     System.Console.WriteLine($"i = {i}");
     System.Console.WriteLine($"sum = {sum}");
    
    
     if (sum == 3)
    {
        System.Console.WriteLine($"We have the magical sum of {sum}");
    }
    System.Console.WriteLine();

    
    }