using System.Linq;

namespace TextTillerson
{
   abstract class InputEventType
    {


        public static readonly InputEventType InvalidInput = null;
        public static readonly InputEventType QuitGame = new QuitGameInputEventType(); // quit stop close speedrunstrats
        public static readonly InputEventType Win = new WinInputEventType(); //  Oats 
        public static readonly InputEventType CheckStats = new CheckStatsInputEventType(); // stats status statuitismaximus
        public static readonly InputEventType Look = new LookInputEventType(); //Look Check See
        public static readonly InputEventType PickUp = new PickupInputEventType();
        public static readonly InputEventType Fight = new FightInputEventType(); // Battle Attack Swing Stab
        public static readonly InputEventType Walk = new WalkInputEventType(); // go travel move
        public static readonly InputEventType Jump = new JumpInputEventType(); // Climb Grab Leap
        public static readonly InputEventType Dodge = new DodgeInputEventType(); // Evade Roll Duck Dive
        public static readonly InputEventType Block = new BlockInputEventType(); // Shield Lid
        public static readonly InputEventType Crawl = new CrawlInputEventType();
        public static readonly InputEventType SelfMurder = new SelfMurderInputEventType(); //Die
        public static readonly InputEventType Revive = new ReviveInputEventType(); // ressurect revive phoenixdown
        public static readonly InputEventType Kill = new KillInputEventType(); // murder gank



       

        private class QuitGameInputEventType : InputEventType
        {
            public QuitGameInputEventType()
            {

            }

            public override void HandleGameEvent(Game game, string[] parameters)
            {
                game.handleQuit();
            }
        }

        private class CheckStatsInputEventType : InputEventType
        {
            public CheckStatsInputEventType()
            {

            }

            public override void HandleGameEvent(Game game, string[] parameters)
            {
                game.showStats();
            }
        }

        private class JumpInputEventType : InputEventType
        {
            public JumpInputEventType()
            {

            }

            public override void HandleGameEvent(Game game, string[] parameters)
            {

            }
        }

        private class WinInputEventType : InputEventType
        {
            public WinInputEventType()
            {

            }

            public override void HandleGameEvent(Game game, string[] parameters)
            {
                
            }
        }

        private class LookInputEventType : InputEventType
        {
            public LookInputEventType()
            {

            }

            public override void HandleGameEvent(Game game, string[] parameters)
            {
                Location[] l = game.getWalkableLocations();
               game.displayLocations(l);

            }
        }

        private class PickupInputEventType : InputEventType
        {
            public PickupInputEventType()
            {

            }

            public override void HandleGameEvent(Game game, string[] parameters)
            {
                Item[] items = game.getNearbyItems();
                string target = parameters[0];
                foreach (Item i in items)
                {
                    if (i.Name == target)
                    {
                        game.Grab(i);
                        return;
                    }
                }

                game.UnrealItem();



            }
        }

        private class FightInputEventType : InputEventType
        {
            public FightInputEventType()
            {

            }

            public override void HandleGameEvent(Game game, string[] parameters)
            {
                
            }
        }

        private class DodgeInputEventType : InputEventType
        {
            public DodgeInputEventType()
            {

            }

            public override void HandleGameEvent(Game game, string[] parameters)
            {
                
            }
        }

        private class BlockInputEventType : InputEventType
        {
            public BlockInputEventType()
            {

            }

            public override void HandleGameEvent(Game game, string[] parameters)
            {

            }
        }

        private class CrawlInputEventType : InputEventType
        {
            public CrawlInputEventType()
            {

            }

            public override void HandleGameEvent(Game game, string[] parameters)
            {

            }
        }

        private class SelfMurderInputEventType : InputEventType
        {
            public SelfMurderInputEventType()
            {

            }

            public override void HandleGameEvent(Game game, string[] parameters)
            {

            }
        }

        private class ReviveInputEventType : InputEventType
        {
            public ReviveInputEventType()
            {

            }

            public override void HandleGameEvent(Game game, string[] parameters)
            {

            }
        }

        private class KillInputEventType : InputEventType
        {
            public KillInputEventType()
            {

            }

            public override void HandleGameEvent(Game game, string[] parameters)
            {

            }
        }

        private class WalkInputEventType : InputEventType
        {
            public WalkInputEventType()
            {

            }

            public override void HandleGameEvent(Game game, string[] parameters)
            {
                if (!parameters.Any())
                {
                    InputEventType.Look.HandleGameEvent(game, parameters);
                    return;
                }
                Location[] ls = game.getWalkableLocations();
                string direction = parameters[0];
                foreach (Location l in ls)
                {
                    if (l.Name == direction)
                    {
                        game.Walk(l);
                        return;
                    }
                }

                game.InvalidWalkLocation();
            }
        }

        public abstract void HandleGameEvent(Game game, string[] parameters);
       

    }
}