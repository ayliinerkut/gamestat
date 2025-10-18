using System;
using System.Collections.Generic;
using GameStatsApi.Models;

namespace GameStatsApi.Services
{
    public class GameDataService
    {
        private static readonly string[] Heroes = { "Warrior", "Mage", "Sniper", "Tank" };

        public List<GameStat> GetStats()
        {
            var stats = new List<GameStat>();
            var random = new Random();
            
            // 50 oyuncu için rastgele veri oluştur
            for (int i = 1; i <= 50; i++)
            {
                int matches = random.Next(10, 500);
                double winRate = Math.Round(random.NextDouble() * 0.7 + 0.3, 2); // %30 ile %100 arası
                int kills = random.Next(50, 1000);
                int deaths = random.Next(30, 800);

                stats.Add(new GameStat
                {
                    PlayerId = i,
                    Username = $"Player_{i:000}",
                    MatchesPlayed = matches,
                    WinRate = winRate,
                    Kills = kills,
                    Deaths = deaths,
                    MainHero = Heroes[random.Next(Heroes.Length)]
                });
            }

            return stats;
        }
    }
}