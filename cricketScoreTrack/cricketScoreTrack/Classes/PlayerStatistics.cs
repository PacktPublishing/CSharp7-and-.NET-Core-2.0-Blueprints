using cricketScoreTrack.BaseClasses;
using System;

namespace cricketScoreTrack.Classes
{
    public class PlayerStatistics : Statistics
    {
        [Obsolete("Abstracted out to AllRounderStatistics, BowlerStatistics and BatsmanStatistics")]
        public override int CalculatePlayerRank(Player player)
        {
            #region Logic
            /* - Batsman
            Runs scored
            Ratings of the opposing bowling attack; the higher the combined ratings of the attack, the more value is given to the batsman’s innings (in proportion)
            The level of run-scoring in the match, and the team’s innings total; an innings of 100 runs in a match where all teams scored 500 is worth less than 100 runs in a match where all teams were bowled out for 200. And if a team scores 500 in the first innings and 200 in the second innings, a century in the second innings will get more credit than in the first innings (because the general level of run scoring was higher in the first innings)
            Out or not out (a not out innings receives a bonus)
            The result. Batsmen who score highly in victories receive a bonus. That bonus will be higher for highly rated opposition teams (i.e. win bonus against the current Australia team is higher than the bonus against Bangladesh.)
            */

            /* - Bowler
            Wickets taken and runs conceded
            Ratings of the batsmen dismissed (at present, the wicket of Kumar Sangakkara is worth more than that of Makhaya Ntini – but if Ntini's rating improves, the value of his wicket will increase accordingly)
            The level of run-scoring in the match; bowling figures of 3-50 in a high-scoring match will boost a bowler’s rating more than the same figures in a low-scoring match
            Heavy workload; bowlers who bowl a large number of overs in the match get some credit, even if they take no wickets;
            The result. Bowlers who take a lot of wickets in a victory receive a bonus. That bonus will be higher for highly rated opposition teams
            */ 
            #endregion
            return 1;
        }
        
        [Obsolete("Abstracted out to AllRounderStatistics, BowlerStatistics and BatsmanStatistics")]
        public override double CalculateStrikeRate(Player player)
        {            
            switch (player)
            {
                case AllRounder allrounder:
                    return (allrounder.BowlerBallsBowled / allrounder.BowlerWickets);

                case Batsman batsman:
                    return (batsman.BatsmanRuns * 100) / batsman.BatsmanBallsFaced;

                case Bowler bowler:
                    return (bowler.BowlerBallsBowled / bowler.BowlerWickets);

                default:
                    throw new ArgumentException("Incorrect argument supplied");
            }
        }
    }
}