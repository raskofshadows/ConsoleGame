using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextTillerson
{
    class ConsoleGame : Game
    {

        public override void handleQuit()
        {

            Console.WriteLine("Thanks for the money.");
            Console.WriteLine("Press F to pay respect.");
            Console.ReadKey(false);
            Environment.Exit(0);

        }

        public override void showStats()
        {
            Console.WriteLine(string.Format(
            "Hp:{0, -6} Movement:{1, -2}{2}Reach:{3,-3} Jump:{4, -6}", stats.healthValue, stats.movementDistance, Environment.NewLine, stats.reachDistance, stats.jumpDistance)); 
            
        }

        public string getInput()
        {
            string result = Console.ReadLine();
            return result;

        }

        internal override void Walk(Location l)
        {
            base.Walk(l);
            Console.WriteLine($"You walk to the {l.Name}. Were those footsteps above you?");

        }

        internal override void InvalidWalkLocation()
        {
            Console.WriteLine("You can't go there.");

        }

        internal override void displayLocations(Location[] locations)
        {
            Console.WriteLine("You see some interesting things."); //Implement items eventually with look.
            foreach (var location in locations)
            {
                Console.WriteLine(location.Name);
            }
           

        }


    }
}
