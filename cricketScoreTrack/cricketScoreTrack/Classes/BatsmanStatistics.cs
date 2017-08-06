using cricketScoreTrack.BaseClasses;
using System;

namespace cricketScoreTrack.Classes
{
    public class BatsmanStatistics : Statistics
    {
        public override int CalculatePlayerRank(Player player)
        {
            return 1;
        }

        public override double CalculateStrikeRate(Player player)
        {
            if (player is Batsman batsman)
            {
                return (batsman.BatsmanRuns * 100) / batsman.BatsmanBallsFaced;
            }
            else
                throw new ArgumentException("Incorrect argument supplied");
        }
    }
}