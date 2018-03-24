using cricketScoreTrack.BaseClasses;
using System;

namespace cricketScoreTrack.Classes
{
    public class BowlerStatistics : Statistics
    {
        public override int CalculatePlayerRank(Player player)
        {
            return 1;
        }

        public override double CalculateStrikeRate(Player player)
        {
            if (player is Bowler bowler)
            {
                return (bowler.BowlerBallsBowled / bowler.BowlerWickets);
            }
            else
                throw new ArgumentException("Incorrect argument supplied");
        }
    }
}