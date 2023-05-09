using Moq;

namespace TextStats.Test
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            // arrange
            var searchWord = "a";
            var myLineSource = new MockLineReader("Det var en gang.", "Bla bla bla", "Aerje");

            // act
            var statsService = new StatService(myLineSource);
            var stats = statsService.GetStats(searchWord);

            // assert
            Assert.AreEqual(3, stats.LineCountIgnoreCase);
            Assert.AreEqual(2, stats.LineCountExact);
            Assert.AreEqual(3, stats.TotalLines);
        }

        [Test]
        public void Test2()
        {
            // arrange
            var searchWord = "a";
            var mock = new Mock<ILineReader>();
            mock.SetupSequence(lr => lr.GetNextLineOrNull())
                .Returns("Det var en gang.")
                .Returns("Bla bla bla")
                .Returns("Aerje")
                .Returns((string)null);

            // act
            var statsService = new StatService(mock.Object);
            var stats = statsService.GetStats(searchWord);

            // assert
            Assert.AreEqual(3, stats.LineCountIgnoreCase);
            Assert.AreEqual(2, stats.LineCountExact);
            Assert.AreEqual(3, stats.TotalLines);
        }
    }
}