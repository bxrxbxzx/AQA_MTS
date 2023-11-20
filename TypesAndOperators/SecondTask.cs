namespace TypesAndOperators;

    public class SecondTask
    {
        public static void main()
        {
            Console.Write("Введите число: ");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a > 50 || a < -50)
            {
                Console.WriteLine("Некорректное число!");
                return;
                
            }

            if (a >= -40 && a <= -10)
            {
                Console.WriteLine("Число попало в промежуток между -40 и -10!");
                return;
            }
            
            if (a >= -9 && a <= 0)
            {
                Console.WriteLine("Число попало в промежуток между -9 и 0!");
                return;
            }
            
            if (a >= 1 && a <= 10)
            {
                Console.WriteLine("Число попало в промежуток между 1 и 10!");
                return;
            }

            if (a >= 11 && a <= 40)
            {
                Console.WriteLine("Число попало в промежуток между 11 и 40!");
                return;
            }
            if (a > 50 & a < -50)
            {
                Console.WriteLine("Число не попадает ни в один указанный промежуток");
            }

        }
    }



