using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    internal class WorldFactory
    {
        internal World CreateWorld()
        {
            World newWorld = new World();

            newWorld.AddLocation(0, -1, "Home"
                , "This is your Home"
                , "/Engine;component/Images/Locations/Home.png");

            newWorld.AddLocation(-1, -1, "Farmer's House"
                , "This is the house of your neighbor, Farmer Ted."
                , "/Enging;component/Images/Locations/FarmHouse.png");

            newWorld.AddLocation(-2, -1, "Farmer's Field"
                , "There are rows of corn frowing here, with giant rats hiding between them."
                , "/Enging;component/Images/Locations/FarmFields.png");

            return newWorld;
        }
    }
}
