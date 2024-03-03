using System;
using CelestialObject;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstroSimCharts
{
    class ObjectSystem
    {
        // public string name;
        public List<CelestialObject.Object> objects;
        public ObjectSystem()
        {
            // name = systemName;
            objects = new List<CelestialObject.Object>();
        }

        public void addPlanet(Planet newPlanet)
        {
            objects.Add(newPlanet);
            Console.WriteLine($"Added new Planet : {newPlanet.name} to system");
        }

        public void addSatellite(Satellite newSatellite)
        {
            objects.Add(newSatellite);
            Console.WriteLine($"Added new Satellite: {newSatellite.name} to system");
        }

        private void fillChart()
        {

        }


    }
}
