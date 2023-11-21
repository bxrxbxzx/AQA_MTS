using System.Diagnostics;

namespace TypesAndOperators;

public class ThirdTask
{
    public static void Main1()
    {
        /*Dictionary<string, string> weather = new Dictionary<string, string>();

        var wDictionary = new Dictionary<string, string>()
        {
            { "Осень", "Autumn" },
            { "Зима", "Winter" },
            { "Весна", "Spring" },
            { "Лето", "Summer" },
            { "Дождь", "Rain" },
            { "Солнце", "Sun" },
            { "Туман", "Fog" },
            { "Бриз", "Breeze" },
            { "Снег", "Snow" },
            { "Ветер", "Wind" },
        };

        Console.Write("Введите слово о погоде на русском языке: ");

        if (Console.ReadLine("Осень")
        {
            Console.WriteLine(wDictionary<string>);
        }
    }*/
        //не понял, как сделать вывод.
        
        
        //Пошел по простому пути.
        
        Console.WriteLine("Введите слово о погоде на русском языке: ");
        var weather = Convert.ToString(Console.ReadLine());
        
        switch(weather.ToLower())
        {
            case "осень":
                Console.WriteLine("autumn");
                break;
            case "зима":
                Console.WriteLine("winter");
                break;
            case "весна":
                Console.WriteLine("spring");
                break;
            case "лето":
                Console.WriteLine("summer");
                break;
            case "дождь":
                Console.WriteLine("rain");
                break;
            case "солнце":
                Console.WriteLine("sun");
                break;
            case "туман":
                Console.WriteLine("fog");
                break;
            case "бриз":
                Console.WriteLine("breeze");
                break;
            case "снег":
                Console.WriteLine("snow");
                break;
            case "ветер":
                Console.WriteLine("wind");
                break;
            default:
                Console.WriteLine("Слово отсутствует в словаре");
                break;
        }
        
    }
}


    

    