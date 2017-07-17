using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Name: Gabriel Norman
 * Date: July 17, 2017
 * Description: This is the Abstract Planet class
 * Version: 0.1 - Created the planet class
 */
namespace Comp123___Assignment_4
{   /// <summary>
    /// This is the public abstract planet class - all other planet classes inherit from this class
    /// </summary>
    public abstract class Planet
    {
        // PRIVATE INSTANCE VARIABLES (FIELDS)
        private double _diameter;
        private double _mass;
        private int _moonCount;
        private string _name;
        private double _orbitalPeriod;
        private int _ringCount;
        private double _rotationPeriod;

        //PUBLIC PROPERTIES
        public double Diameter
        {
            get
            {
                return this._diameter;
            }
        }

        public double Mass
        {
            get
            {
                return this._mass;
            }
        }

        public int MoonCount
        {
            get
            {
                return this._moonCount;
            }
            set
            {
                this._moonCount = value;
            }
        }

        public string Name
        {
            get
            {
                return this._name;
            }
         }

        public double OrbitalPeriod
        {
            get
            {
                return this._orbitalPeriod;
            }
            set
            {
                this._orbitalPeriod = value;
            }
        }

        public int RingCount
        {
            get
            {
                return this._ringCount;
            }
            set
            {
                this._ringCount = value;
            }
        }

        public double RotationPeriod
        {
            get
            {
                return this._rotationPeriod;
            }
            set
            {
                this._rotationPeriod = value;
            }
        }

            // CONSTRUCTORS ---------------------------------------------
            /// <summary>
            /// This is the main constructor for the Planet class - 
            /// it takes three parameters  a string: name, a double: diameter, and another double: mass
            /// /// </summary>
            /// <param name="name"></param>
            /// <param name="diameter"></param>
            /// <param name="mass"></param>
            public Planet(string name , double diameter, double mass)
        {
            this._name = name;
            this._diameter = diameter;
            this._mass = mass;

        }
        //PRIVATE METHODS - (THERE ARE NONE)

        // PUBLIC METHODS 
        public override string ToString()
        {
            string returnString;

            returnString = string.Format("Planet Name: {0}\n Planet Diameter: {1}\nPlanet Mass: {2}\n Planet's MoonCount: {3}\n Planet's Ring#: {4}\n Planet's Orbital Period: {5}\n  Planet's Rotation Period: {6}\n\n", Name, Diameter, Mass, MoonCount, RingCount, OrbitalPeriod, RotationPeriod );
            return returnString;
        }
    }
    }

