using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Basic_Bullet_Journal
{
    public class Habits
    {
        public string Name { get; set; }

        public Dictionary<string, string> Tracked { get; set; } //dictionary --> key: day, value: t/f

        public Habits(string name, Dictionary<string, string> track)
        {
            this.Name = name;
            this.Tracked = track;
        }

        public override string ToString() => $"{Name}:\n S|{Tracked["sunday"]}|  M|{Tracked["monday"]}|  T|{Tracked["tuesday"]}|  W|{Tracked["wednesday"]}|  T|{Tracked["thursday"]}|  F|{Tracked["friday"]}|  S|{Tracked["saturday"]}|";
    }
}
