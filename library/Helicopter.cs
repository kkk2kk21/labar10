using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class Helicopter : zAircraft
    {
        //Количество лопастей
        private int numberBlades;

        public int NumberBlades
        {
            get => numberBlades;
            set
            {
                if (value < 0)
                {
                    numberBlades = 0;
                }
                else if (value > 8)
                {
                    numberBlades = 8;
                }
                else
                {
                    numberBlades = value;
                }
            }
        }

        public Helicopter() : base()
        {
            NumberBlades = 0;
        }
        public Helicopter(string model, int year, string engineType, int crewMembers, int numberBlades, int number) : base(model, year, engineType, crewMembers, number)
        {
            this.NumberBlades = numberBlades;
        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Количество лопастей: {NumberBlades}");
        }
        public new void ShowNotV()
        {
            base.ShowNotV();
            Console.WriteLine($"Количество лопастей: {NumberBlades}");
        }
        public override void Init()
        {
            base.Init();
            Console.Write("Введите количество лопастей: ");
            NumberBlades = TryParseToIntFunc(Console.ReadLine());
        }
        public override void RandomInit()
        {
            base.RandomInit();
            NumberBlades = random.Next(0, 8);
        }
       
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (obj is Helicopter f && base.Equals(obj))
            {
                return this.NumberBlades == f.NumberBlades;
            }
            return false;
        }

        public override string ToString()
        {
            return base.ToString() + $", Количество лопастей {NumberBlades}";
        }

        public override object Clone()
        {
            return new Helicopter(Model, ReleaseYear, EngineType, CrewMembers, NumberBlades, id.Number);
        }

        public override object ShallowCopy()
        {
            return this.MemberwiseClone();
        }
    }
}
