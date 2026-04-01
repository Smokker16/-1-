using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР_1_Создание_и_использование_классов_Шапкин
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();  // 1. Создание объекта класса Car
            myCar.Brand = "Жигули";// 2. Задание значений полям объекта
            myCar.Number = "Т144ТО";
            myCar.Mileage = 10350;
            myCar.Show();// 3. Вывод данных
            double averageMileage = myCar.GetAverageMileage(2);// 4. Расчет среднегодового пробега (возраст 2 года)
            Console.WriteLine($"Среднегодовой пробег: {averageMileage} км/год");

            Console.ReadKey();
        }
    } 
    class Car
    {
        public string Brand;
        public string Number;
        public int Mileage;

        public void Show()
        {
            Console.WriteLine($"Марка: {Brand}");
            Console.WriteLine($"Гос. номер: {Number}");
            Console.WriteLine($"Пробег: {Mileage} км");
        }

        public double GetAverageMileage(int age)
        {
            if (age > 0)
                return (double)Mileage / age;
            else
                return 0;
        }
    }
}

