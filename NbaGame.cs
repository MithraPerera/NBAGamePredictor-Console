using System;
namespace NBAGamePredictor
{
    public class NbaGame
    {
        public NbaGame()
        {
        }

        public int matchnumber { get; set; }
        public int roundnumber { get; set; }
        public DateTime date { get; set; }
        public string location { get; set; }
        public string hometeam { get; set; }
        public string awayteam { get; set; }
        public string result { get; set; }
    }
}

