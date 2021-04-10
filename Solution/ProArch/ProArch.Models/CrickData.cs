using System;

namespace ProArch.Models
{
    public class CrickData
    {
        public int Match_Id { get; set; }
        public string Season { get; set; }
        public DateTime Start_Date { get; set; }
        public string Venue { get; set; }
        public string Innings { get; set; }
        public float Ball { get; set; }
        public string Batting_Team { get; set; }
        public string Bowling_Team { get; set; }
        public string Striker { get; set; }
        public string Non_Striker { get; set; }
        public string Bowler { get; set; }
        public string Runs_Off_Bat { get; set; }
        public string Extras { get; set; }
        public string Wides { get; set; }
        public string Noballs { get; set; }
        public string Byes { get; set; }
        public string Legbyes { get; set; }
        public string Penalty { get; set; }
        public string Wicket_Type { get; set; }
        public string Player_Dismissed { get; set; }
        public string Other_Wicket_Type { get; set; }
        public string Other_Player_Dismissed { get; set; }
    }
}
