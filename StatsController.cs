using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using GameStatsApi.Models;
using GameStatsApi.Services;

namespace GameStatsApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StatsController : ControllerBase
    {
        private readonly GameDataService _dataService;

        public StatsController()
        {
            _dataService = new GameDataService();
        }

        [HttpGet]
        public ActionResult<IEnumerable<GameStat>> GetGameStats()
        {
            var stats = _dataService.GetStats();
            return Ok(stats);
        }
        
        // Örnek: Kazanma oranına göre ilk 10 oyuncuyu getiren bir uç nokta
        [HttpGet("top10")]
        public ActionResult<IEnumerable<GameStat>> GetTop10Players()
        {
            var stats = _dataService.GetStats();
            var top10 = stats.OrderByDescending(s => s.WinRate).Take(10);
            return Ok(top10);
        }
    }
}