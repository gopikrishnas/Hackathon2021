using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using ProArch.BusinessLayer.Interfaces;
using ProArch.Models;
using System.Collections.Generic;

namespace ProArch.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CricketController : ControllerBase
    {
        private readonly ICricketDataManager cricketDataManager;
        public CricketController(ICricketDataManager cricketDataManager)
        {
            this.cricketDataManager = cricketDataManager;
        }

        [HttpGet]
        [Route("{typeId:int}")]
        public IEnumerable<CricketInsight> GetCrickDataInsights(int typeId)
        {
            return cricketDataManager.GetCrickDataInsights((InsightTypes)typeId);
        }
    }
}
