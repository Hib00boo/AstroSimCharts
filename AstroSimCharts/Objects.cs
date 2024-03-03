using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelestialObject
{
    public abstract class Object
    {
        public string name { get; set; }
        public float mass { get; set; }

        // TODO : Check if decimal needed
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }

        public Object(string objName, float objMass, float posX, float posY, float posZ)
        {
            name = objName;
            mass = objMass;
            X = posX;
            Y = posY;
            Z = posZ;
        }

        public abstract void IdentifySelf();
        public void StatePosition()
        {
            Console.WriteLine($"{name} : My position is at [{X}, {Y}, {Z}]. \n");
        }
    }

    public class Planet : Object
    {
        public Planet(string planetName, float planetMass, float posX, float posY, float posZ) : base(planetName, planetMass, posX, posY, posZ)
        {
            Console.WriteLine($"Planet {name} has been created");
        }

        public override void IdentifySelf() 
        { 
            Console.WriteLine($"Planet {name} has a mass of {mass} kg.\n"); 
        }
    }

    public class Satellite : Object
    {
        public Satellite(string planetName, float planetMass, float posX, float posY, float posZ) : base(planetName, planetMass, posX, posY, posZ)
        {
            Console.WriteLine($"Satellite {name} has been created");
        }
        public override void IdentifySelf()
        {
            Console.WriteLine($"Satellite {name} has a mass of {mass} kg.\n");
        }
    }
}
