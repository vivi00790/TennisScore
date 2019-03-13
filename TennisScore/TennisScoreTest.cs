using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TennisScore
{
    [TestClass]
    public class TennisScoreTest
    {
        [TestMethod]
        public void Score_0_0_should_return_All_Love()
        {
            Assert.AreEqual("all love", setUpScore(0, 0).Score());
        }

        [TestMethod]
        public void Score_1_0_should_return_15_Love()
        {
            Assert.AreEqual("15 love", setUpScore(1, 0).Score());

        }

        [TestMethod]
        public void Score_0_1_should_return_Love_15()
        {
            Assert.AreEqual("love 15", setUpScore(0, 1).Score());

        }

        [TestMethod]
        public void Score_2_0_should_return_30_Love()
        {
            Assert.AreEqual("30 love", setUpScore(2, 0).Score());

        }

        [TestMethod]
        public void Score_0_2_should_return_Love_30()
        {
            Assert.AreEqual("love 30", setUpScore(0, 2).Score());

        }

        private Judge setUpScore(int player1Score, int player2Score)
        {
            return new Judge { Player1Score = player1Score, Player2Score = player2Score };
        }
    }
}
