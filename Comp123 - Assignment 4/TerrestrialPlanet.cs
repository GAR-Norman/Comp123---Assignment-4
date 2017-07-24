using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Name: Gabriel Norman
 * Date: July 17, 2017
 * Description: This is the TerrestrialPlanet class
 * Version: 0.3 - Created the TerrestrialPlanet class
 */
namespace Comp123___Assignment_4
{
    /// <summary>
    /// This is the TerrestrialPlanet Class
    /// </summary>
    public class TerrestrialPlanet : Planet, IHasMoons, IHabitable
    {
        // PRIVATE INSTANCE VARIABLES
        private bool _oxygen;


        //PUBLIC PROPERTIES - There are None 

        // CONSTRUCTORS ---------------------------------------------
        /// <summary>
        /// This is the main constructor for the GiantPlanet class - 
        /// it takes four parameters  a string: name, a double: diameter, 
        /// another double: mass, and another string: type
        /// /// </summary>
        /// <param name="name"></param>
        /// <param name="diameter"></param>
        /// <param name="mass"></param>
        /// <param name="oxygen"></param> 
       
            public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen)
            : base(name, diameter, mass)
        {
            this._oxygen = oxygen; 
             
        }

        //PRIVATE METHODS 

        //PUBLIC METHODS
        public bool HasMoons()
        {
            bool returnValue = false;

            if (MoonCount > 0)
            {
                returnValue = true;
            }

            return returnValue;
        }

         public bool Habitable()
        {
            bool returnValue = false;

            if (_oxygen == true)
            {
                returnValue = true;
            }

            return returnValue;
        }

    }
}
