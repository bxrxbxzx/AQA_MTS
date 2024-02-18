namespace AQA_MTS;

public class First_Task_Arrays



{
    public static void Main()
    {
        //Создайте массив целых чисел.Вывести сообщение.Ввод с консоли
        int[] array1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
        foreach (int i in array1)
        {
            Console.Write($"{i} ");
        }

        Console.WriteLine("\nВведите число: ");
        int fNumber = Convert.ToByte(Console.ReadLine());
        
        foreach (int i in array1)
        {
            if (array1.Contains(fNumber))
            {
                Console.WriteLine($"Число {fNumber} входит в массив!");
            }
            else
            {
                Console.WriteLine($"Число {fNumber} не входит в массив!");
            }
            break;
        }
    }
}



