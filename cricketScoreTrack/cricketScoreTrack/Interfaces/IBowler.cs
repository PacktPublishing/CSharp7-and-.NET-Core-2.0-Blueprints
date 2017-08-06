namespace cricketScoreTrack.Interfaces
{
    interface IBowler
    {
        double BowlerSpeed { get; set; }
        string BowlerType { get; set; } // Fast, MediumPace, Spin
        int BowlerBallsBowled { get; set; }
        int BowlerMaidens { get; set; }        
        int BowlerWickets { get; set; }        
        //double BowlerStrikeRate { get; } // Balls Bowled / Wickets Taken        
        double BowlerEconomy { get; } // Runs Conceded / Overs Bowled
        int BowlerRunsConceded { get; set; }
        int BowlerOversBowled { get; set; }
    }
}
