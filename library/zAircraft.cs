using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class zAircraft : IInit, IComparable, ICloneable
    {
        //Модель воздушного судна
        protected string model;
        //Год производства
        protected int releaseYear;
        //Тип двигателя
        protected string engineType;
        //Количество членов экипажа
        protected int crewMembers;

        //Массивы для заполнения информации об воздушном судне
        //модели вертолетов: Ми-8, Ми-24, модели самолетов: МС-21, Ту-214, модели истребителей: Су-57, МиГ-31
        static string[] models = { "Ми-8", "Ми-24", "МС-21", "Ту-214", "Су-57", "МиГ-31" };
        //Типы двигателей, которые находятся в эксплуатации в авиации: двигатель внутреннего сгорания (ДВС); воздушно-реактивный двигатель (ВРД): турбореактивный двигатель (ТРД)
        static string[] engineTypes = { "ДВС", "ВРД", "ТРД" };

        public IdNumber id;
        protected static Random random = new Random();

        // Свойство для доступа к модели воздушного судна
        public string Model
        {
            get => model;
            set
            {
                bool isInArray = Array.Exists(models, element => element == value);
                if (isInArray)
                    model = value;
                else
                    model = "Noname";
            }
        }
        // Свойство для доступа к году выпуска воздушного судна
        public int ReleaseYear
        {
            get => releaseYear;
            set
            {
                if (value < 1903)
                    releaseYear = 1903;
                else if (value > 2024)
                    releaseYear = 2024;
                else
                    releaseYear = value;
            }
        }
        // Свойство для доступа к типу двигателя
        public string EngineType
        {
            get => engineType;
            set
            {
                bool isInArray = Array.Exists(engineTypes, element => element == value);
                if (isInArray)
                    engineType = value;
                else
                    engineType = "Noname";
            }
        }
        // Свойство для доступа к числу экипажа воздушного судна
        public int CrewMembers
        {
            get => crewMembers;
            set
            {
                if (value < 0)
                    crewMembers = 0;
                else
                    crewMembers = value;
            }
        }

        //Конструктор без параметра
        public zAircraft()
        {
            Model = "Noname";
            ReleaseYear = 1903;
            EngineType = "Noname";
            CrewMembers = 0;
            id = new IdNumber(1);
        }
        //Конструктор с параметрами
        public zAircraft(string model, int year, string engineType, int crewMembers, int number)
        {
            this.Model = model;
            this.ReleaseYear = year;
            this.EngineType = engineType;
            this.CrewMembers = crewMembers;
            id = new IdNumber(number);
        }
        //Метод для вывода информации о воздушном судне
        public virtual void Show()
        {
            Console.WriteLine($"Модель: {Model}\nГод выпуска: {ReleaseYear}\nТип двигателя: {EngineType}\nКоличество членов экипажа: {CrewMembers}");
        }
        //Метод для вывода информации о воздушном судне не виртуальный
        public void ShowNotV()
        {
            Console.WriteLine($"Модель: {Model}\nГод выпуска: {ReleaseYear}\nТип двигателя: {EngineType}\nКоличество членов экипажа: {CrewMembers}");
        }
        //Метод для инициализации
        public virtual void Init()
        {
            Console.WriteLine("Введите модель:");
            Model = Console.ReadLine();
            Console.WriteLine("Введите год:");
            try
            {
                ReleaseYear = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                ReleaseYear = -78;
            }
            Console.WriteLine("Введите тип двигателя:");
            EngineType = Console.ReadLine();
            Console.WriteLine("Введите количество членов экипажа:");
            try
            {
                CrewMembers = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                CrewMembers = -78;
            }
            Console.WriteLine("Введите id воздушного судна:");
            try
            {
                id.Number = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                id.Number = -78;
            }
        }
        //Метод для рандомной инициализации
        public virtual void RandomInit()
        {
            Model = models[random.Next(models.Length)];
            ReleaseYear = random.Next(1930, 2024);
            EngineType = engineTypes[random.Next(engineTypes.Length)];
            CrewMembers = random.Next(0, 100);
            id.Number = random.Next(1, 100);
        }
        //Метод для сравнения
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (obj is zAircraft f)
            {
                return this.Model == f.Model
                    && this.ReleaseYear == f.ReleaseYear
                    && this.EngineType == f.EngineType
                    && this.CrewMembers == f.CrewMembers
                    && this.id.Number == f.id.Number;
            }
            return false;
        }

        public int CompareTo(object obj)
        {
            zAircraft f = obj as zAircraft;
            if (f != null)
                return ReleaseYear.CompareTo(f.ReleaseYear);
            else
                return -1;
        }

        public virtual object Clone()
        {
            return new zAircraft(Model, ReleaseYear, EngineType, CrewMembers, id.Number);
        }
        public virtual object ShallowCopy()
        {
            return this.MemberwiseClone();
        }
        public override string ToString()
        {
            return $"{id}. Модель: {Model}, год выпуска: {ReleaseYear}, тип двигателя: {EngineType}, количество членов экипажа: {CrewMembers}";
        }
        public class IdNumber
        {
            private int number;
            public int Number
            {
                get => number;
                set
                {
                    if (value < 1)
                        number = 1;
                    else
                        number = value;
                }
            }
            public IdNumber()
            {
                Number = 1;
            }
            public IdNumber(int number)
            {
                Number = number;
            }
            public override bool Equals(object obj)
            {
                if (obj == null) return false;
                if (obj is IdNumber t)
                    return this.Number == t.Number;
                return false;
            }
            public override string ToString()
            {
                return $"id: {Number}";
            }
        }
    }
}
