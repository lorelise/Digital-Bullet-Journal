using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Bullet_Journal
{
    public class Habits
    {
        public string Name { get; set; }

        public Dictionary<string, string> Tracked { get; set; } //dictionary --> key: day, value: t/f

        //public Habits()
        //{
        //    Completed = new Dictionary<string, string>()
        //    {
        //        {"Sunday", "O"},
        //        {"Monday", "O" },
        //        {"Tuesday", "O" },
        //        {"Wednesday", "O"},
        //        {"Thursday", "X"},
        //        {"Friday", " "},
        //        {"Saturday", " "}

        //    };
        //}

        public Habits(string name, Dictionary<string, string> track)
        {
            this.Name = name;
            this.Tracked = track;
        }

        public override string ToString() => $"{Name}:\n S|{Tracked["Sunday"]}|  M|{Tracked["Monday"]}|  T|{Tracked["Tuesday"]}|  W|{Tracked["Wednesday"]}|  T|{Tracked["Thursday"]}|  F|{Tracked["Friday"]}|  S|{Tracked["Saturday"]}|";
    }
}
