using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.ViewModels
{
    public class GameSession
    {
        public Player CurrentPlayer { get; set; }

        public GameSession()
        {
            CurrentPlayer = new Player
            {
                Name = "Auston",
                Gold = 1000000,
                CharacterClass = "Fighter",
                ExperiencePoints = 0,
                HitPoints = 10,
                Level = 1
            };
        }
    }
}