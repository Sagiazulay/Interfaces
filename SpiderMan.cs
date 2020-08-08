using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class SpiderMan : Human, IClimb
    {
        public int Speed { get; private set; }
        public SpiderMan(string name, int age, int speed) : base(name, age)
        {
            Speed = speed;
        }
        public void Climb()
        {
            Console.WriteLine("SpiderMan Is Climbing");
        }
        public void ActivateSuperPowers()
        {
            Console.WriteLine("Activiating My Super Powers!");
            Climb();
        }
        public override string ToString()
        {
            return $"{base.ToString()} ";
        }


    }
}
