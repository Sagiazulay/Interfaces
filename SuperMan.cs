using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class SuperMan : Human, IFly
    {
        public int WebLeft { get; private set; }
        public SuperMan(string name, int age, int webLeft) : base(name, age)
        {
            WebLeft = webLeft;
        }
        public void ActivateSuperPowers()
        {
            Console.WriteLine("Activiating My Super Powers!");
            Fly();
        }
        public void Fly()
        {
            Console.WriteLine("IM Flying!!");
        }
        public override string ToString()
        {
            return $"{base.ToString()}";
        }
    }
}
