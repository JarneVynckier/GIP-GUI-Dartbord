using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIP_GUI_Dartbord
{
    public class Player
    {
        public Player()
        {
            RemainingScore = 501;
        }
        
        public List<int> Scores { get; set; }
        public int Winner { get; set; }
        public int Legs { get; set; }
        public int RemainingScore { get; set; }

    }
}
