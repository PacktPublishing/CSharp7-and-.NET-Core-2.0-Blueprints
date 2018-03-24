using cricketScoreTrack.BaseClasses;
using System;

namespace cricketScoreTrack.Classes
{
    public class AllRounderStatistics : Statistics
    {
        public override int CalculatePlayerRank(Player player)
        {
            return 1;
        }

        public override double CalculateStrikeRate(Player player)
        {
            if (player is AllRounder allrounder)
            {
                return (allrounder.BowlerBallsBowled / allrounder.BowlerWickets);
            }
            else
                throw new ArgumentException("Incorrect argument supplied");            
        }
    }
}