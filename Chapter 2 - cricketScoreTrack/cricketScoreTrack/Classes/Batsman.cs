using cricketScoreTrack.BaseClasses;
using cricketScoreTrack.Interfaces;

namespace cricketScoreTrack.Classes
{
    public class Batsman : Player, IBatter
    {
        
        #region Player
        public override string FirstName { get; set; }
        public override string LastName { get; set; }
        public override int Age { get; set; }
        public override string Bio { get; set; }
        #endregion

        #region IBatsman
        public int BatsmanRuns { get; set; }
        public int BatsmanBallsFaced { get; set; }
        public int BatsmanMatch4s { get; set; }
        public int BatsmanMatch6s { get; set; }

                
        //public double BatsmanBattingStrikeRate => (BatsmanRuns * 100) / BatsmanBallsFaced; // (Runs Scored x 100) / Balls Faced

        //public override int CalculatePlayerRank()
        //{
        //    return 0;
        //}
        
        #endregion
    }
}