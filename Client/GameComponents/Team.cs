using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameComponents
{
    public class Team
    {
        public string name { get; set; }

        public string color { get; set; }

        public int score { get; set; }

        public User[] users { get; set; }

        public Tile[] tiles { get; set; }
    }
}
