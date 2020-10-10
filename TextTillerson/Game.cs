using System;
using System.Collections.Generic;

namespace TextTillerson
{
    internal abstract class Game
    {
       protected Stats stats = new Stats();
        Location current = new Location();

        Dictionary<Location, Location[]> directions = new Dictionary<Location, Location[]>();


        public Game()
        {
            stats.movementDistance = 2;
            stats.reachDistance = 1;
            stats.jumpDistance = 1;
            stats.healthValue = 10;

             

        }

        public abstract void handleQuit();


        public abstract void showStats();

        internal Location[] getWalkableLocations()
        {
            Location[] ls;
            bool found = directions.TryGetValue(current, out ls);
            if (found)
            {
                return ls;
            }
            return new Location[]
            {

            };
        }

        internal void Walk(Location l)
        {
             current = l;


        }

        internal void InvalidWalkLocation()
        {
            throw new NotImplementedException();
        }
    }
}