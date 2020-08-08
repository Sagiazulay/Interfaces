using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Flash : Human, IFlash
    {
        public int Voltage { get; private set; }
        public Flash(string name, int age, int voltage) : base(name, age)
        {
            this.Voltage = voltage;
        }
        public void FireLightnings()
        {
            Console.WriteLine("FireLightnings Power");
        }
        public void ActivateSuperPowers()
        {
            Console.WriteLine("Activiating My Super Powers!");
            FireLightnings();
        }

        public override string ToString()
        {
            return $"{base.ToString()} :";
        }


    }
}
