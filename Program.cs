using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task__2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в игру \"Очко\"! Сколько карт у Вас на руках?");
            int amountOfCards = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
          
            

            for (int i = 1; i <= amountOfCards; i++)
            {
                Console.WriteLine($"Введите номинал {i}-й карты: ");
                string nominal = Console.ReadLine();

                switch (nominal)
                {
                    case "2":sum += 2; break;
                    case "3": sum += 3; break;
                    case "4": sum += 4; break;
                    case "5": sum += 5; break;
                    case "6": sum += 6; break;
                    case "7": sum += 7; break;
                    case "8": sum += 8; break;
                    case "9": sum += 9; break;
                    case "10":
                    case "J":
                    case "D":
                    case "K":
                    case "T": sum += 10; break;

                    default:
                        Console.WriteLine("Такой карты в колоде нет. Попробуйте еще.");
                        i--;
                        break;








                }
                Console.WriteLine($"\nСумма всех карт в руке:{sum}");
                Console.ReadKey();
            }
        }
    }
}
