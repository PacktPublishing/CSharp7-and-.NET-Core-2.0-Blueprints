namespace cricketScoreTrack.BaseClasses
{
    public abstract class Statistics
    {
        public abstract double CalculateStrikeRate(Player player);
        public abstract int CalculatePlayerRank(Player player);
    }
}