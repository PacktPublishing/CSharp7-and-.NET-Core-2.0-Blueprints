namespace cricketScoreTrack.BaseClasses
{
    public abstract class Player
    {
        public abstract string FirstName { get; set; }
        public abstract string LastName { get; set; }
        public abstract int Age { get; set; }
        public abstract string Bio { get; set; }

        //abstract public int CalculatePlayerRank();
    }
}