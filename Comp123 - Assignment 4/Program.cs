using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Name: Gabriel Norman
 * Date: July 24th, 2017
 * Description: This is the driver class
 * Version: 0.9 - Cleaned up the driver class and created the readkey method. 
 * Also fixed the abstract methods in IHabitable, IHasMoond, and IHasRings so they function properly. 
 */
namespace Comp123___Assignment_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Giant planet object
            GiantPlanet giantPlanet = new GiantPlanet("Venus", 400009909.8, 677778787.998, "Gas");
            Console.WriteLine(giantPlanet);

            //Terrestrial planet object
            TerrestrialPlanet terrestrialPlanet = new TerrestrialPlanet("Jupiter", 45556666565.8, 877787778, true);
            Console.WriteLine(terrestrialPlanet);

            // Driver class method that reads users key input
            WaitForAnyKey();
           
        }

        //Public Methods

        public static void WaitForAnyKey()
        {
            Console.ReadKey();
        }
    }
}
