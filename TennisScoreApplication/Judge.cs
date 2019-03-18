using System;
using System.Collections.Generic;

namespace TennisScoreApplication
{
    public class Judge
    {
        public int Player1Score { get; set; }
        public int Player2Score { get; set; }
        public string Player1Name { get; set; }
        public string Player2Name { get; set; }

        private string _winText = "win";
        private string _deuceText = "deuce";

        public string Score()
        {
            if (Player1Score == 0 && Player2Score == 0)
            {
                return "all love";
            }

            return GenerateResultText();
        }

        private string GenerateResultText()
        {
            if (Player1Score > 2 && Player2Score > 2)
            {
                if (Player1Score == Player2Score)
                {
                    return _deuceText;
                }

                if (Math.Abs(Player1Score - Player2Score) == 1)
                {
                    return HigherScorePlayerName + " " + _deuceText;
                }

                if (Math.Abs(Player1Score - Player2Score) > 1 && HigherScore >= 4)
                {
                    return HigherScorePlayerName + " " + _winText;
                }
            }

            if (HigherScore >= 4)
            {
                return HigherScorePlayerName + " " + _winText;
            }
            return GetPlayerScoreText(Player1Score) + " " + GetPlayerScoreText(Player2Score);
        }

        public int HigherScore
        {
            get
            {
                if(Player1Score != Player2Score)
                    return Player1Score > Player2Score ? Player1Score : Player2Score;
                return -1;
            }
        }

        public string HigherScorePlayerName
        {
            get
            {
                if (Player1Score != Player2Score)
                    return Player1Score > Player2Score ? Player1Name : Player2Name;
                return string.Empty;
            }
        }

        private string GetPlayerScoreText(int score)
        {
            if (score > 3) return score.ToString();
            return _scoreText[score];
        }

        private readonly Dictionary<int, string> _scoreText = new Dictionary<int, string>()
        {
            {0, "love"},
            {1, "15"},
            {2, "30"},
            {3, "40"},
        };
    }
}