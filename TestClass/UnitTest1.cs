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
                string expected = "true";
                //creating object of TicTacToeGame class
                TicTacToeGame select = new TicTacToeGame();
                string actual = select.DisplayBoard();
                

                //Assert
                //comparing actual and expected value
                Assert.AreEqual(expected, actual);
            }
        }
    }
}
