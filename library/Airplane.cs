using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class Airplane : zAircraft
    {
        //Количество пассажиров
        protected int numberPassanger;
        //Максимальная дальность полета
        protected int maxDistance;

        public int NumberPassanger
        {
            get => numberPassanger;
            set
            {
                if (value < 0)
                {
                    numberPassanger = 0;
                }
                numberPassanger = value;
            }
        }

        public int MaxDistance
        {
            get => maxDistance;
            set
            {
                if (value < 0)
                {
                    maxDistance = 0;
                }
                maxDistance = value;
            }
        }

        public Airplane() : base()
        {
            NumberPassanger = 0;
            MaxDistance = 0;
        }
        public Airplane(string model, int year, string engineType, int crewMembers, int numberPassanger, int maxDistance, int number) : base(model, year, engineType, crewMembers, number)
        {
            this.NumberPassanger = numberPassanger;
            this.MaxDistance = maxDistance;
        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Количество пассажиров: {NumberPassanger}, максимальная дистанция полета: {MaxDistance}");
        }
        public new void ShowNotV()
        {
            base.ShowNotV();
            Console.WriteLine($"Количество пассажиров: {NumberPassanger}, максимальная дистанция полета: {MaxDistance}");
        }
        public override void Init()
        {
            base.Init();
            Console.Write("Введите количество пассажиров: ");
            try
            {
                NumberPassanger = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                NumberPassanger = -78;
            }
            Console.Write("Введите максимальную дистанцию полета: ");
            try
            {
                MaxDistance = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                MaxDistance = -78;
            }
        }
        public override void RandomInit()
        {
            base.RandomInit();
            NumberPassanger = random.Next(0, 1000);
            MaxDistance = random.Next(0, 10000);
        }
        
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (obj is Airplane f && base.Equals(obj))
            {
                return this.NumberPassanger == f.NumberPassanger
                    && this.MaxDistance == f.MaxDistance;
            }
            return false;
        }
        public override string ToString()
        {
            return base.ToString() + $", число пассажиров {NumberPassanger}, максимальная дистанция полета {MaxDistance}";
        }
        public override object Clone()
        {
            return new Airplane(Model, ReleaseYear, EngineType, CrewMembers, NumberPassanger, MaxDistance, id.Number);
        }

        public override object ShallowCopy()
        {
            return this.MemberwiseClone();
        }
    }
}
