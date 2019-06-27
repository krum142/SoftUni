using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SpaceStationRecruitment
{
    public class SpaceStation
    {
        private List<Astronaut> astronauts;
        private int count;
        public SpaceStation(string name,int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.Count = count;
            astronauts = new List<Astronaut>();
        }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count { get; set; }

        public void Add(Astronaut astronaut)
        {
            if(Count < Capacity)
            {
                this.astronauts.Add(astronaut);
                Count++;
            }
        }

        public bool Remove(string name)
        {
            if (astronauts.Any(a => a.Name == name))
            {
                var austronautToDelete = astronauts.First(a => a.Name == name);
                astronauts.Remove(austronautToDelete);
                return true;
            }
            else
            {
                return false;
            }
        }
        public Astronaut GetOldestAstronaut()
        {
            Astronaut oldestAustronaut = astronauts.OrderByDescending(a => a.Age).First();
            return oldestAustronaut;
        }
        public Astronaut GetAstronaut(string name)
        {
            Astronaut whatAstrunautToReturn = astronauts.FirstOrDefault(a => a.Name == name);
            return whatAstrunautToReturn;
        }
        public string Report()
        {
            return $"Astronauts working at Space Station {this.Name}:" +Environment.NewLine + string.Join(Environment.NewLine,astronauts);
        }
    }
}
