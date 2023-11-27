namespace TypesAndOperators;

public class FourthTask
{
    public static void Main3()
    {
        Console.WriteLine("Введите число: ");
        int nmbr = Convert.ToInt32(Console.ReadLine());
        /*
        //первое решение
        if ((nmbr % 2) == 0)

        {
            Console.Write("Число четное");
        }
        else
        {
            Console.WriteLine("Число нечетное");
        }
        return;
        */
        
        //второе решение

        if ((nmbr &1)== 1)
        {
            Console.WriteLine("Число нечетное");
        }
        else
        {
            Console.WriteLine("Число четное");
        }

    }
    
}