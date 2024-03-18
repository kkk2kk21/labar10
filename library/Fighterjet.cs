using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class Fighterjet : Airplane
    {
        //Класс истребителя
        private string classFighterjet;

        static string[] classifications = { "Фронтовой", "Перехватчик", "Палубный", "Многофункциональный", "Тактический" };
        public string ClassFighterjet
        {
            get => classFighterjet;
            set
            {
                bool isInArray = Array.Exists(classifications, element => element == value);
                if (isInArray)
                {
                    classFighterjet = value;
                }
                else
                {
                    classFighterjet = "Noname";
                }
            }
        }
        public Fighterjet() : base()
        {
            ClassFighterjet = "Noname";
        }
        public Fighterjet(string model, int year, string engineType, int crewMembers, int numberPassanger, int maxDistance, string classFighterjet, int number) : base(model, year, engineType, crewMembers, numberPassanger, maxDistance, number)
        {
            this.ClassFighterjet = classFighterjet;
        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Класс истребителя: {ClassFighterjet}");
        }
        public new void ShowNotV()
        {
            base.ShowNotV();
            Console.WriteLine($"Класс истребителя: {ClassFighterjet}");
        }
        public override void Init()
        {
            base.Init();
            Console.Write("Введите класс истребителя");
            ClassFighterjet = Console.ReadLine();
        }
        public override void RandomInit()
        {
            base.RandomInit();
            ClassFighterjet = classifications[random.Next(classifications.Length)];
        }
        
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (obj is Fighterjet f && base.Equals(obj))
            {
                return this.ClassFighterjet == f.ClassFighterjet;
            }
            return false;
        }
        public override string ToString()
        {
            return base.ToString() + $", класс истребителя {ClassFighterjet}";
        }
        public override object Clone()
        {
            return new Fighterjet(Model, ReleaseYear, EngineType, CrewMembers, NumberPassanger, MaxDistance, ClassFighterjet, id.Number);
        }

        public override object ShallowCopy()
        {
            return this.MemberwiseClone();
        }
    }
}
