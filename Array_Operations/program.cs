using System;
public class arithmetic_operation
{
    public static void Main()
    {
        Console.Write("Enter number1: ");
        int num1= Convert.ToInt32(Console.ReadLine());
 
        Console.Write("Enter number2: ");
        int num2= Convert.ToInt32(Console.ReadLine());
   
        Console.WriteLine("{0} + {1} = {2}", num1, num2, num1+num2);
        Console.WriteLine("{0} - {1} = {2}", num1, num2, num1-num2);
        Console.WriteLine("{0} x {1} = {2}", num1, num2, num1*num2);
        Console.WriteLine("{0} / {1} = {2}", num1, num2, num1/num2);
        Console.WriteLine("{0} mod {1} = {2}", num1, num2, num1%num2);
   }
}