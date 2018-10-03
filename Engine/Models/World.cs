using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class World
    {
        // Empty list that holds our Location objs
        private List<Location> _locations = new List<Location>();

        // Default Constructor
        public World() { }

        internal void AddLocation(int xCoord, int yCoord, string name, string desc, string imageName)
        {
            Location loc = new Location
            {
                XCoordinate = xCoord,
                YCoordinate = yCoord,
                Name = name,
                Description = desc,
                ImageName = $"/Engine;component/Images/Locations/{imageName}"
            };

            _locations.Add(loc);
        }

        public Location LocationAt(int xCoord, int yCoord)
        {
            foreach (Location loc in _locations)
            {
                if (loc.XCoordinate == xCoord && loc.YCoordinate == yCoord)
                {
                    return loc;
                }
            }

            return null;
        }
    }
}
