using System;
using System.Collections.Generic;

namespace TextTillerson
{
    internal abstract class Game
    {
       protected Stats stats = new Stats();
        Location current = Location.antechamber;

        Dictionary<Location, Location[]> directions = new Dictionary<Location, Location[]>();

        List<Item> satchel = new List<Item>();

        public Game()
        {
            stats.movementDistance = 2;
            stats.reachDistance = 1;
            stats.jumpDistance = 1;
            stats.healthValue = 10;
            
            directions.Add(Location.antechamber, new Location[] {Location.hallway} );
            directions.Add(Location.hallway, new Location[]{ Location.den, Location.antechamber, Location.kitchen});
            directions.Add(Location.den, new Location[] { Location.hallway });
            directions.Add(Location.kitchen, new Location[] { Location.hallway });



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

        internal virtual void Walk(Location l)
        {
             current = l;


        }

        internal abstract void InvalidWalkLocation();
        internal abstract void displayLocations(Location[] l);
        internal abstract void UnrealItem();

        internal void Grab(Item i)
        {
            throw new NotImplementedException();
        }

        internal Item[] getNearbyItems()
        {
            throw new NotImplementedException();
        }
    }
}