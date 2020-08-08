using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void ActivateHero(ISuperHero superHero)
        {
            superHero.ActivateSuperPowers();
        }
        static void IdentifyHero(ISuperHero hero)
        {
            if (hero is SuperMan)
            {
                Console.WriteLine("SuperMan Detected!");
            }
            else if (hero is SpiderMan)
            {
                Console.WriteLine("SpiderMan Detedted!");
            }
            else
            {
                Console.WriteLine("Flash Detected!");
            }
        }
        static public ISuperHero CreateHero(string hero)
        {

            switch (hero)
            {

                case "SuperMan":
                    Console.WriteLine("It is 1");
                    return new SuperMan("SuperMan", 22, 120); 

                case "SpiderMan":
                    Console.WriteLine("SpiderMan");
                    return new SpiderMan("SpiderMan", 22, 120);

                case "Flash":
                    Console.WriteLine("Flash");
                    return new SpiderMan("Flash", 22, 120);

                default:
                    Console.WriteLine("Nothing");
                    return null;
            }
        }
        static void GetMoreHeroData(ISuperHero hero)
        {
            SpiderMan spiderMan = hero as SpiderMan;
            int speed = spiderMan.Speed;
            SuperMan superMan = hero as SuperMan;
            int WL = superMan.WebLeft;
            Flash flash = hero as Flash;
            int voltage = flash.Voltage;
        }
        static void Main(string[] args)
        {
            ISuperHero[] ISH = new ISuperHero[3];
            
                ISH[0] = new SuperMan("Bros", 50, 250);
                ISH[1] = new SpiderMan("John", 30, 80);
                ISH[2] = new Flash("dean", 22, 220);
            foreach (var ISuperHero in ISH)
            {
                ISuperHero.ActivateSuperPowers();
            }
           
        }

    }
}
