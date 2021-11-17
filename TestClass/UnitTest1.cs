using Microsoft.VisualStudio.TestTools.UnitTesting;
using TickTackGameWorkshop;

namespace TestClass
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            {
                //AAA method
                //Arrange
                string message = "I am in sad mood";
                string expected = "SAD";
                //creating object of moodanalyzer class and passing message
                TicTacToeGame select = new TicTacToeGame();

                //Act
                string actual = select.AnalyseMood();

                //Assert
                //comparing actual and expected value
                Assert.AreEqual(expected, actual);
            }
        }
    }
}
