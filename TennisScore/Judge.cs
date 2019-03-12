namespace TennisScore
{
    internal class Judge
    {
        public Judge()
        {
        }

        public int Player1 { get; set; }
        public int Player2 { get; set; }

        public string Score()
        {
            if (Player1 == 1)
            {
                return "15 love";
            }

            return "all love";
        }
    }
}