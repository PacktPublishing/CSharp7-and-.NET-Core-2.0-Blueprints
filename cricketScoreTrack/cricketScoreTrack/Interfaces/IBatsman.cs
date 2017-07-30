using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cricketScoreTrack.Interfaces
{
    interface IBatsman
    {
        int BatsmanRuns { get; set; }        
        int BatsmanBallsFaced { get; set; }        
        int BatsmanMatch4s { get; set; }        
        int BatsmanMatch6s { get; set; }        
        double BatsmanBattingStrikeRate { get; } // (Runs Scored x 100) / Balls Faced       
        
    }
}
