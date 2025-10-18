namespace GameStatsApi.Models
{
    public class GameStat
    {
        public int PlayerId { get; set; }
        public string Username { get; set; }
        public int MatchesPlayed { get; set; }
        public double WinRate { get; set; } // Kazanma Oranı
        public int Kills { get; set; }
        public int Deaths { get; set; }
        public string MainHero { get; set; }
    }
}