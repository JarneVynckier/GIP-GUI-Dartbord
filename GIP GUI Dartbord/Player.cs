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
            ScoresIndex = -1;
            Scores = new List<int>();
            DartsThrownInLeg = new List<int>();
        }
        
        public List<int> Scores { get; set; }
        public List<int> DartsThrownInLeg { get; set; }
        public int DartsThrownInLegIndex { get; set; }
        public int ScoresIndex { get; set; }
        public int Legs { get; set; }
        public int RemainingScore { get; set; }
        public int DartsThrown { get; set; }

    }
}
