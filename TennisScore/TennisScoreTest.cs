using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TennisScore
{
    [TestClass]
    public class TennisScoreTest
    {
        [TestMethod]
        public void Score_0_0_should_return_All_Love()
        {
            var judge = new Judge {Player1Score = 0, Player2Score = 0};
            var score = judge.Score();
            Assert.AreEqual("all love", score);
        }

        [TestMethod]
        public void Score_1_0_should_return_15_Love()
        {
            var judge = new Judge {Player1Score = 1, Player2Score = 0};
            var score = judge.Score();
            Assert.AreEqual("15 love", score);
        }

        [TestMethod]
        public void Score_0_1_should_return_15_Love()
        {
            var judge = new Judge {Player1Score = 0, Player2Score = 1};
            var score = judge.Score();
            Assert.AreEqual("love 15", score);
        }

        [TestMethod]
        public void Score_2_0_should_return_15_Love()
        {
            var judge = new Judge {Player1Score = 1, Player2Score = 0};
            var score = judge.Score();
            Assert.AreEqual("30 love", score);
        }

        [TestMethod]
        public void Score_0_2_should_return_15_Love()
        {
            var judge = new Judge {Player1Score = 0, Player2Score = 1};
            var score = judge.Score();
            Assert.AreEqual("love 30", score);
        }
    }
}
