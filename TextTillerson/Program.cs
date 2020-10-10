using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextTillerson
{
    class Program
    {
        static void Main(string[] args)
        {
            Dict.Add("quit", InputEventType.QuitGame);
            Dict.Add("stop", InputEventType.QuitGame);
            Dict.Add("close", InputEventType.QuitGame);
            Dict.Add("speedrunstrats", InputEventType.QuitGame);
            Dict.Add("win", InputEventType.Win);
            Dict.Add("stats", InputEventType.CheckStats);
            Dict.Add("status", InputEventType.CheckStats);
            Dict.Add("statuitismaximus", InputEventType.CheckStats);
            Dict.Add("look", InputEventType.Look);
            Dict.Add("check", InputEventType.Look);
            Dict.Add("see", InputEventType.Look);
            Dict.Add("fight", InputEventType.Fight);
            Dict.Add("battle", InputEventType.Fight);
            Dict.Add("swing", InputEventType.Fight);
            Dict.Add("strike", InputEventType.Fight);
            Dict.Add("pickup", InputEventType.PickUp);
            Dict.Add("grab", InputEventType.PickUp);
            Dict.Add("take", InputEventType.PickUp);
            Dict.Add("steal", InputEventType.PickUp);
            Dict.Add("dodge", InputEventType.Dodge);
            Dict.Add("evade", InputEventType.Dodge);
            Dict.Add("roll", InputEventType.Dodge);
            Dict.Add("duck", InputEventType.Dodge);
            Dict.Add("dive", InputEventType.Dodge);
            Dict.Add("walk", InputEventType.Walk);
            Dict.Add("go", InputEventType.Walk);
            Dict.Add("block", InputEventType.Block);
            Dict.Add("crawl", InputEventType.Crawl);
            Dict.Add("die", InputEventType.SelfMurder);
            Dict.Add("revive", InputEventType.Revive);
            Dict.Add("resurrect", InputEventType.Revive);
            Dict.Add("phoenixdown", InputEventType.Revive);
            Dict.Add("murder", InputEventType.Kill);
            Dict.Add("kill", InputEventType.Kill);
            Dict.Add("gank", InputEventType.Kill);

            game = new ConsoleGame();

            while (true)
            {

                InputEventType input; // Declaration
                string[] parameters;
                do
                {
                    string sinput = game.getInput();
                    (input, parameters) = Translate(sinput);

                } while (input == InputEventType.InvalidInput);

                //Console.WriteLine($"debugging:{input}");
                Debug.WriteLine($"debugging:{input}"); //Debug writes to the output console at the bottom left
                RunEvent(input, parameters);


            }

        }

        static Dictionary<string, InputEventType> Dict = new Dictionary<string, InputEventType>();
        static ConsoleGame game;


        static (InputEventType, string[]) Translate(string input)
        {
            InputEventType result;
            string[] inputarray = input.Split(' ');
            bool found = Dict.TryGetValue(inputarray[0], out result);
            if (found) return (result, inputarray.Skip(1).ToArray());
            return (InputEventType.InvalidInput, null);
        }

        static void RunEvent(InputEventType placeholderevent, string[] parameters)
        {
            placeholderevent.HandleGameEvent(game, parameters);

           
        }


    }
}

