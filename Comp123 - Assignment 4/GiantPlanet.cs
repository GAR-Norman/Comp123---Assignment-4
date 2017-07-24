using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Gabriel Norman
 * Date: July 17, 2017
 * Description: This is the GiantPlanet class
 * Version: 0.2 - Created the GiantPlanet class
 */
namespace Comp123___Assignment_4
{
     
    public class GiantPlanet : Planet, IHasMoons, IHasRings
    {
        // PRIVATE INSTANCE VARIABLES
        private string _type;


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
        /// <param name="type"></param>

        public GiantPlanet(string name, double diameter, double mass, string type)
            :base(name, diameter, mass)
        {
            this._type = type;
        }
        
        
            //PRIVATE METHODS 
        
            
            //PUBLIC METHODS
        public bool HasMoons()
        {
            bool returnValue = false; 

            if(MoonCount > 0)
            {
                returnValue = true; 
            }

            return returnValue;
        }

         public bool HasRings()
        {
            bool returnValue = false;

            if (RingCount > 0)
            {
                returnValue = true;
            }

            return returnValue;
        }
    }
}
