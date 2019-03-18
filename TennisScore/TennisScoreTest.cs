using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TennisScore
{
    [TestClass]
    public class TennisScoreTest
    {
        private static Judge _initializedJudge;
        [TestInitialize]
        public void SetUp()
        {
            _initializedJudge = new Judge();
        }

        [TestCleanup]
        public void TearDown()
        {
            _initializedJudge = null;
        }

        [TestMethod]
        public void Score_0_0_should_return_All_Love()
        {
            SetUpScore(0,0);
            Assert.AreEqual("all love", _initializedJudge.Score());
        }

        private static void SetUpScore(int player1Score, int player2Score)
        {
            _initializedJudge.Player1Score = player1Score;
            _initializedJudge.Player2Score = player2Score;
        }

        [TestMethod]
        public void Score_1_0_should_return_15_Love()
        {
            SetUpScore(1, 0);
            Assert.AreEqual("15 love", _initializedJudge.Score());

        }

        [TestMethod]
        public void Score_0_1_should_return_Love_15()
        {
            SetUpScore(0, 1);
            Assert.AreEqual("love 15", _initializedJudge.Score());

        }

        [TestMethod]
        public void Score_2_0_should_return_30_Love()
        {
            SetUpScore(2, 0);
            Assert.AreEqual("30 love", _initializedJudge.Score());

        }

        [TestMethod]
        public void Score_0_2_should_return_Love_30()
        {
            SetUpScore(0, 2);
            Assert.AreEqual("love 30", _initializedJudge.Score());

        }

        [TestMethod]
        public void Score_3_0_should_return_40_Love()
        {
            SetUpScore(3, 0);
            Assert.AreEqual("40 love", _initializedJudge.Score());

        }

        [TestMethod]
        public void Score_0_3_should_return_Love_40()
        {
            SetUpScore(0, 3);
            Assert.AreEqual("love 40", _initializedJudge.Score());

        }

        [TestMethod]
        public void Score_4_0_should_return_player1_name_win()
        {
            _initializedJudge.Player1Name = "p1";
            SetUpScore(4, 0);
            Assert.AreEqual("p1 win", _initializedJudge.Score());

        }

        [TestMethod]
        public void Score_0_4_should_return_player2_name_win()
        {
            _initializedJudge.Player2Name = "p2";
            SetUpScore(0, 4);
            Assert.AreEqual("p2 win", _initializedJudge.Score());

        }

        [TestMethod]
        public void Score_4_4_should_return_deuce()
        {
            SetUpScore(4, 4);
            Assert.AreEqual("deuce", _initializedJudge.Score());
        }

        [TestMethod]
        public void Score_3_3_should_return_deuce()
        {
            SetUpScore(3, 3);
            Assert.AreEqual("deuce", _initializedJudge.Score());
        }

        [TestMethod]
        public void Score_2_2_should_return_30_30()
        {
            SetUpScore(2, 2);
            Assert.AreEqual("30 30", _initializedJudge.Score());
        }

        [TestMethod]
        public void Score_3_2_should_return_40_30()
        {
            SetUpScore(3, 2);
            Assert.AreEqual("40 30", _initializedJudge.Score());
        }

        [TestMethod]
        public void Score_4_3_should_return_player1_deuce()
        {
            _initializedJudge.Player1Name = "p1";
            SetUpScore(4, 3);
            Assert.AreEqual("p1 deuce", _initializedJudge.Score());
        }

        [TestMethod]
        public void Score_5_3_should_return_player1_win()
        {
            _initializedJudge.Player1Name = "p1";
            SetUpScore(5, 3);
            Assert.AreEqual("p1 win", _initializedJudge.Score());
        }

        [TestMethod]
        public void Score_4_6_should_return_player2_win()
        {
            _initializedJudge.Player2Name = "p2";
            SetUpScore(4, 6);
            Assert.AreEqual("p2 win", _initializedJudge.Score());
        }


    }
}
