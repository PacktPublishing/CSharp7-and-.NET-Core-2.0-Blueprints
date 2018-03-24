using cricketScoreTrack.BaseClasses;
using cricketScoreTrack.Interfaces;

namespace cricketScoreTrack.Classes
{
    public class Bowler : Player, IBowler
    {
        #region Player
        public override string FirstName { get; set; }
        public override string LastName { get; set; }
        public override int Age { get; set; }
        public override string Bio { get; set; }
        #endregion

        #region IBowler
        public double BowlerSpeed { get; set; }
        public string BowlerType { get; set; } // Fast, MediumPace, Spin
        public int BowlerBallsBowled { get; set; }
        public int BowlerMaidens { get; set; }
        public int BowlerWickets { get; set; }
        public double BowlerEconomy => BowlerRunsConceded / BowlerOversBowled; // Runs Conceded / Overs Bowled
        public int BowlerRunsConceded { get; set; }
        public int BowlerOversBowled { get; set; }
        #endregion
    }
}