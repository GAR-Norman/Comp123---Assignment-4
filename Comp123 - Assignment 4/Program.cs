using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Name: Gabriel Norman
 * Date: July 27th, 2017
 * Description: This is the driver class
 * Version: 1.0 - Gave values to the mooncount and ring count and called interface methods.
 * Also made the output slightly more presentable. 
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
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine(giantPlanet);
            Console.WriteLine("This planet has moons: {0}", giantPlanet.HasMoons());
            Console.WriteLine("This planet has rings: {0} \n", giantPlanet.HasRings());
            Console.WriteLine("-----------------------------------------------");



            //Terrestrial planet object
            TerrestrialPlanet terrestrialPlanet = new TerrestrialPlanet("Earth", 45556666565.8, 877787778, true);
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine(terrestrialPlanet);
            Console.WriteLine("This planet has moons: {0}", terrestrialPlanet.HasMoons());
            Console.WriteLine("This planet has rings: {0} \n", terrestrialPlanet.Habitable());
            Console.WriteLine("-----------------------------------------------");


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
