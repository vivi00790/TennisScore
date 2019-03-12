namespace TennisScore
{
    internal class Judge
    {
        public Judge()
        {
        }

        public int Player1Score { get; set; }
        public int Player2Score { get; set; }

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
            return GetPlayerScoreText(Player1Score) + " " + GetPlayerScoreText(Player2Score);
        }

        private string GetPlayerScoreText(int score)
        {
            switch (score)
            {
                case 0:
                    return "love";
                case 1:
                    return "15";

            }

            return string.Empty;
        }
    }
}