using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
// 3.	Создать не менее трех методов управления классом и методы доступа к его закрытым полям.
//4.	Создать метод, в который передаются аргументы по ссылке. 
//5.	Создать не менее двух статических полей (различных типов), представляющих общие характеристики объектов данного класса. 
//6.	Обязательным требованием является реализация нескольких перегруженных конструкторов, аргументы которых определяются студентом,
//исходя из специфики реализуемого класса, а так же реализация конструктора по умолчанию.
//7.	Создать статический конструктор.
//8.	Создать массив (не менее 5 элементов) объектов созданного класса.
//9.	Создать дополнительный метод для данного класса в другом файле, используя ключевое слово partial.
{ 
   public class Oven
    {
        private int temperature;
        private int time;
        static int size;
        private string color;
        private string type;

        public Oven()
        {
            type = "electrical";
            color = "black";

        }
        static  Oven()
        {
            size.ToString();
        }

        public Oven(string type)
        {
            this.type = type;
            color = "black";
        }

         Oven(string type,string color)
        {
            this.type = type;
            this.color = color;
        }

        public static int GetSize()
        {
            return size;
        }

        public static void SetSize(int value)
        {
            size = value;
        }

        public void SetTemperature(int temp)
        {
            this.temperature = temp;
        }

        public int GetTemperature()
        {
            return temperature;
        }

        public void SetTime(int time)
        {
            this.time = time;
        }

        public int GetTime()
        {
            return time;
        }

        public void Cooking(int time, int temperature)
        {
            int nameObject=0;
            if (temperature==0)
            {
                Console.WriteLine("не вкл. температуру");
            }
            for (int i=time;i>=0;i--)
            {
                nameObject++;
                if(i==0)
                {
                    Console.WriteLine("еда готова");
                }
            }
        }
        
        public void AmountOven(int size, int placeKitchen)
        {
            if (size < placeKitchen)
            {
                Console.WriteLine("место для духовки есть");
            }
        }
        public bool OnOf(bool on)
        {
            return on;
        }
    }
}
