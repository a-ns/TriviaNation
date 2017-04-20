using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameComponents;

namespace PUser
{
    public class Team
    {
        string name { get; set; }

        string color { get; set; }

        User[] users { get; set; }

        Tile[] tiles { get; set; }
    }
}
