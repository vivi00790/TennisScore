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
            _initializedJudge.Player1Score = 0;
            _initializedJudge.Player2Score = 0;
            Assert.AreEqual("all love", _initializedJudge.Score());
        }

        [TestMethod]
        public void Score_1_0_should_return_15_Love()
        {
            _initializedJudge.Player1Score = 1;
            _initializedJudge.Player2Score = 0;
            Assert.AreEqual("15 love", _initializedJudge.Score());

        }

        [TestMethod]
        public void Score_0_1_should_return_Love_15()
        {
            _initializedJudge.Player1Score = 0;
            _initializedJudge.Player2Score = 1;
            Assert.AreEqual("love 15", _initializedJudge.Score());

        }

        [TestMethod]
        public void Score_2_0_should_return_30_Love()
        {
            _initializedJudge.Player1Score = 2;
            _initializedJudge.Player2Score = 0;
            Assert.AreEqual("30 love", _initializedJudge.Score());

        }

        [TestMethod]
        public void Score_0_2_should_return_Love_30()
        {
            _initializedJudge.Player1Score = 0;
            _initializedJudge.Player2Score = 2;
            Assert.AreEqual("love 30", _initializedJudge.Score());

        }

        [TestMethod]
        public void Score_3_0_should_return_45_Love()
        {
            _initializedJudge.Player1Score = 3;
            _initializedJudge.Player2Score = 0;
            Assert.AreEqual("45 love", _initializedJudge.Score());

        }

        [TestMethod]
        public void Score_0_3_should_return_Love_45()
        {
            _initializedJudge.Player1Score = 0;
            _initializedJudge.Player2Score = 3;
            Assert.AreEqual("love 45", _initializedJudge.Score());

        }

        [TestMethod]
        public void Score_4_0_should_return_player1_name_win()
        {
            _initializedJudge.Player1Score = 3;
            _initializedJudge.Player2Score = 0;
            Assert.AreEqual("45 love", _initializedJudge.Score());

        }

        [TestMethod]
        public void Score_0_4_should_return_player2_name_win()
        {
            _initializedJudge.Player1Score = 0;
            _initializedJudge.Player2Score = 3;
            Assert.AreEqual("love 45", _initializedJudge.Score());

        }
    }
}
