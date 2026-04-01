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
            // 1. Создание объекта класса Car
            Car myCar = new Car();

            // 2. Задание значений полям объекта
            myCar.Brand = "Жигули";
            myCar.Number = "Т144ТО";
            myCar.Mileage = 10350;

            // 3. Вывод данных
            myCar.Show();

            // 4. Расчет среднегодового пробега (возраст 2 года)
            double averageMileage = myCar.GetAverageMileage(2);
            Console.WriteLine($"Среднегодовой пробег: {averageMileage} км/год");

            Console.ReadKey();
        }
    }  // Закрывающая скобка для Program

    // Класс Car - ВНЕ класса Program!
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

