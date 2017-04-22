using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameComponents
{
    public class Tile
    {
        int questionNum { get; set; }

        public string question { get; set; }

        public Answer[] answers { get; set; }
    }
}
