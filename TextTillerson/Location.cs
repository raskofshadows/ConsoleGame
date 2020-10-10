using System.Collections.Generic;

namespace TextTillerson
{
    internal class Location
    {
        public List<Item> items { get; private set; }
        

        public string Name { get; internal set; }

    public static Location antechamber = new Location() {Name = "antechamber", items = new List<Item>() } ;
    public static Location den = new Location() { Name = "den", items = new List<Item>() {Item.redbuckler} };
    public static Location kitchen = new Location() { Name = "kitchen", items = new List<Item>() };
    public static Location hallway = new Location() { Name = "hallway", items = new List<Item>() };
    }



}