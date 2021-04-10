using ProArch.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProArch.BusinessLayer.Interfaces
{
    public interface ICricketDataManager
    {
        IEnumerable<CricketInsight> GetCrickDataInsights(InsightTypes insightType);
    }
}
