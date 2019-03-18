using System;

namespace TennisScore
{
    public class Judge
    {
        public Judge()
        {
        }

        public int Player1Score { get; set; }
        public int Player2Score { get; set; }
        public string Player1Name { get; set; }
        public string Player2Name { get; set; }

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
            if (Player1Score >= 2 && Player2Score >= 2)
            {
                if (Player1Score == Player2Score && Player1Score > 2)
                {
                    return "deuce";
                }
            }

            if (Player1Score == 4 || Player2Score == 4)
            {
                return Higher + " win";
            }
            return GetPlayerScoreText(Player1Score) + " " + GetPlayerScoreText(Player2Score);
        }

        public string Higher => Player1Score > Player2Score ? Player1Name : Player2Name;

        private string GetPlayerScoreText(int score)
        {
            switch (score)
            {
                case 0:
                    return "love";
                case 1:
                    return "15";
                case 2:
                    return "30";
                case 3:
                    return "40";

            }

            return string.Empty;
        }
    }
}