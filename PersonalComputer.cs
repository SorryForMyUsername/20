using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_2
{
    /// <summary>
    /// Персональный компьютер
    /// </summary>
    internal class PersonalComputer
    {
        /// <summary>
        /// Модель компьютера
        /// </summary>
        public string model;

        /// <summary>
        /// Тактовая частота процессора
        /// </summary>
        public double clockFrequency;

        /// <summary>
        /// Объём оперативной памяти
        /// </summary>
        public int sizeOfRAM;

        /// <summary>
        /// Объём жёсткого диска
        /// </summary>
        public int hardDriveCapacity;

        /// <summary>
        /// Конструктор по умолчанию или без параметров
        /// </summary>
        public PersonalComputer() { }

        /// <summary>
        /// Конструктор с одним параметром
        /// </summary>
        /// <param name="model">Модель компьютера</param>
        public PersonalComputer(string model)
        {
            this.model = model;
        }

        /// <summary>
        /// Конструктор с двумя параметрами
        /// </summary>
        /// <param name="model">Модель компьютера</param>
        /// <param name="clockFrequency">Тактовая частота процессора</param>
        public PersonalComputer(string model, double clockFrequency) : this(model)
        {
            this.clockFrequency = clockFrequency;
        }

        /// <summary>
        /// Конструктор с тремя параметрами
        /// </summary>
        /// <param name="model">Модель компьютера</param>
        /// <param name="clockFrequency">Тактовая частота процессора</param>
        /// <param name="sizeOfRAM">Объём оперативной памяти</param>
        public PersonalComputer(string model, double clockFrequency, int sizeOfRAM) : this(model, clockFrequency)
        {
            this.sizeOfRAM = sizeOfRAM;
        }

        /// <summary>
        /// Конструктор с четырьмя параметрами
        /// </summary>
        /// <param name="model">Модель компьютера</param>
        /// <param name="clockFrequency">Тактовая частота процессора</param>
        /// <param name="sizeOfRAM">Объём оперативной памяти</param>
        /// <param name="hardDriveCapacity">Объём жёсткого диска</param>
        public PersonalComputer(string model, double clockFrequency, int sizeOfRAM, int hardDriveCapacity) : this(model, clockFrequency, sizeOfRAM)
        {
            this.hardDriveCapacity = hardDriveCapacity;
        }

        /// <summary>
        /// Выводит информацию о ПК на консоль
        /// </summary>
        public void Info()
        {
            Console.WriteLine($"Модель: {model}, Тактовая частота: {clockFrequency}, " +
                $"Объём оперативной памяти: {sizeOfRAM}, Объём жёсткого диска: {hardDriveCapacity}");
        }

        /// <summary>
        /// Метод, возвращающий строковое представление объекта.
        /// </summary>
        /// <returns>Информация о ПК в строковом виде</returns>
        public override string ToString()
        {
            return $"Модель: {model}, Тактовая частота: {clockFrequency}, " +
                $"Объём оперативной памяти: {sizeOfRAM}, Объём жёсткого диска: {hardDriveCapacity}";
        }
    }
}
