using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;
using Engine.Factories;

namespace Engine.ViewModels
{
    public class GameSession
    {
        public World CurrentWorld { get; set; }
        public Player CurrentPlayer { get; set; }
        public Location CurrentLocation { get; set; }

        public GameSession()
        {
            CurrentPlayer = new Player
            {
                Name = "Auston",
                Gold = 5,
                CharacterClass = "Fighter",
                ExperiencePoints = 0,
                HitPoints = 10,
                Level = 1
            };

            WorldFactory Factory = new WorldFactory();
            CurrentWorld = Factory.CreateWorld();

            CurrentLocation = CurrentWorld.LocationAt(0, 0);
        }
    }
}