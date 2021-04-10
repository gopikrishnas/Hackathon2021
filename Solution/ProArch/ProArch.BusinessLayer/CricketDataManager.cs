using ProArch.BusinessLayer.Interfaces;
using ProArch.DataLayer.Interfaces;
using ProArch.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace ProArch.BusinessLayer
{
    public class CricketDataManager : ICricketDataManager
    {
        readonly ICricketDataService cricketDataService;
        public CricketDataManager(ICricketDataService cricketDataService)
        {
            this.cricketDataService = cricketDataService;
        }
        public IEnumerable<CricketInsight> GetCrickDataInsights(InsightTypes insightType)
        {
            switch (insightType)
            {
                case InsightTypes.BY_VENUE:
                    return cricketDataService.GetByVenue();
                case InsightTypes.BY_BATTING_TEAM:
                    return cricketDataService.GetByBattingTeam();
                case InsightTypes.BY_BOWLING_TEAM:
                    return cricketDataService.GetByBowlingTeam();
                default:
                    return null;
            }
        }
    }
}
