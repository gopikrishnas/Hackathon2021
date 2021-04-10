using ProArch.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProArch.DataLayer.Interfaces
{
    public interface ICricketDataService
    {
        IEnumerable<CricketInsight> GetByVenue();
        IEnumerable<CricketInsight> GetByBattingTeam();
        IEnumerable<CricketInsight> GetByBowlingTeam();
    }
}
