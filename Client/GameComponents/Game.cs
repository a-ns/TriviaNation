using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameComponents
{
    public class Game
    {
        public string gameName { get; set; }
        public Team[] nations { get; set; }
        public Tile[] tiles { get; set; }
        //public int[] scores { get; set; }
    }
}
