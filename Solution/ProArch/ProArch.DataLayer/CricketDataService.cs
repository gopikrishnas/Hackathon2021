using CsvHelper;
using CsvHelper.Configuration;
using ProArch.DataLayer.Interfaces;
using ProArch.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace ProArch.DataLayer
{
    public class CricketDataService : ICricketDataService
    {
        public List<CrickData> crickData;
        public CricketDataService()
        {
            crickData = new List<CrickData>();
            this.LoadData();
        }

        private void LoadData()
        {
            string[] dataFilePaths = Directory.GetFiles("C:\\Hackathon2021-main\\data", "*.csv");
            foreach (var path in dataFilePaths)
            {
                using (var fs = new StreamReader(path))
                {
                    var config = new CsvConfiguration(CultureInfo.InvariantCulture)
                    {
                        PrepareHeaderForMatch = args => args.Header.ToLower(),
                    };

                    using (var csvReader = new CsvReader(fs, config))
                    {
                        var data = csvReader.GetRecords<CrickData>().ToList();
                        if (data != null)
                            crickData.AddRange(data);
                    }
                }
            }
        }
        public IEnumerable<CricketInsight> GetByVenue()
        {
            return from c in crickData
                   group c by new
                   {
                       c.Venue,
                       c.Match_Id
                   }
                      into gc
                   select new CricketInsight
                   {
                       Name = gc.Key.Venue,
                       Count = gc.Count()
                   };

        }

        public IEnumerable<CricketInsight> GetByBattingTeam()
        {
            return from c in crickData
                   group c by new
                   {
                       c.Batting_Team,
                       c.Match_Id
                   }
                      into gc
                   select new CricketInsight
                   {
                       Name = gc.Key.Batting_Team,
                       Count = gc.Count()
                   };

        }

        public IEnumerable<CricketInsight> GetByBowlingTeam()
        {
            return from c in crickData
                   group c by new
                   {
                       c.Bowling_Team,
                       c.Match_Id
                   }
                      into gc
                   select new CricketInsight
                   {
                       Name = gc.Key.Bowling_Team,
                       Count = gc.Count()
                   };

        }
    }
}
