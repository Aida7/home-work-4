using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            Oven oven = new Oven();
            bool on;int time, temp;
            Console.WriteLine("подключить духовку");
            bool.TryParse(Console.ReadLine(),out on);
            oven.OnOf(on);
            Console.WriteLine("настроить время");
            int.TryParse(Console.ReadLine(), out time);
            oven.SetTime(time);
            Console.WriteLine("настроить температуру");
            int.TryParse(Console.ReadLine(), out temp);
            oven.SetTemperature(temp);
            Console.ReadLine();
            oven.Cooking(oven.GetTime(), oven.GetTemperature());
            oven.AmountOven(8, 9);
        }
    }
}
