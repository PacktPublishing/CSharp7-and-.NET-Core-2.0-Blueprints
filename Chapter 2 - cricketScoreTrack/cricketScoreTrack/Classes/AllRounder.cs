using cricketScoreTrack.BaseClasses;
using cricketScoreTrack.Interfaces;
using System;

namespace cricketScoreTrack.Classes
{
    /// <summary>
    /// An all-rounder is a cricketer who regularly performs well at both batting and bowling.
    /// Although all bowlers must bat and quite a few batsman do bowl occasionally
    /// </summary>
    public class AllRounder : Player, IBatter, IBowler
    {
        #region enums
        //public enum StrikeRate { Bowling = 0, Batting = 1 }
        #endregion

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
        //public double BatsmanBattingStrikeRate => CalculateStrikeRate(StrikeRate.Batting); // (Runs Scored x 100) / Balls Faced
        #endregion

        #region IBowler
        public double BowlerSpeed { get; set; }
        public string BowlerType { get; set; } // Fast, MediumPace, Spin
        public int BowlerBallsBowled { get; set; }
        public int BowlerMaidens { get; set; }
        public int BowlerWickets { get; set; }
        //public double BowlerStrikeRate => CalculateStrikeRate(StrikeRate.Bowling); // Balls Bowled / Wickets Taken
        public double BowlerEconomy => BowlerRunsConceded / BowlerOversBowled; // Runs Conceded / Overs Bowled
        public int BowlerRunsConceded  { get; set; }
        public int BowlerOversBowled { get; set; }
        #endregion
        
        //private double CalculateStrikeRate(StrikeRate strikeRateType)
        //{
        //    switch (strikeRateType)
        //    {
        //        case StrikeRate.Bowling:
        //            // Balls Bowled / Wickets Taken
        //            return (BowlerBallsBowled / BowlerWickets);
        //        case StrikeRate.Batting:
        //            // (Runs Scored x 100) / Balls Faced 
        //            return (BatsmanRuns * 100) / BatsmanBallsFaced;
        //        default:
        //            throw new Exception("Invalid enum");
        //    }
        //}

        //public override int CalculatePlayerRank()
        //{
        //    return 0;
        //}
    }
}