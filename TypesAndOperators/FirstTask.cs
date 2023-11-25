﻿namespace TypesAndOperators;

public class FirstTask
{
    public static void Main()
    {
        //Задание 1. Калькулятор

        Console.Write("Введите первое число: ");
        int firstNumber = Convert.ToByte(Console.ReadLine());

        Console.Write("Введите допустимую операцию (+, -, *, /) : ");
        string? operation = Console.ReadLine();

        Console.Write("Введите второе число: ");
        int secondNumber = Convert.ToByte(Console.ReadLine());
        
        int result = 0;
        
        switch (operation)
        {
            case "+":
                result = firstNumber + secondNumber;  

                break;
            case "-":
                result = firstNumber - secondNumber;  

                break;
            case "*":
                result = firstNumber * secondNumber;  

                break;
            case "/":
               
                if (secondNumber == 0)
                {
                    Console.WriteLine($"На ноль делить нельзя!");
                }
                else
                {
                    result = firstNumber / secondNumber;
                    Console.WriteLine($"Ответ : {result}");
                }

                break;
        }
        Console.WriteLine($"Ответ : {result}");
    }
}