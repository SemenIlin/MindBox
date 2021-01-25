using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculateSquare;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsRightTriangleTest()
        {
            // Arrange
            var firstSide = 3;
            var secondSide = 4;
            var thrirdSide = 5;
            var rightAnswer = true;
            //Act
            var result = Calculate.IsRightTriangle(firstSide, secondSide, thrirdSide);

            // Assert 
            Assert.AreEqual(rightAnswer, result);
        }

        [TestMethod]
        public void IsExistTriangleTest()
        {
            // Arrange
            var firstSide = 1;
            var secondSide = 4;
            var thrirdSide = 5;
            var rightAnswer = false;
            //Act
            var result = Calculate.IsExistTriangle(firstSide, secondSide, thrirdSide);

            // Assert 
            Assert.AreEqual(rightAnswer, result);
        }

        [TestMethod]
        public void GetSquareTriangleTest()
        {
            // Arrange
            var firstSide = 3;
            var secondSide = 4;
            var thrirdSide = 5;
            var rightAnswer = 6;
            //Act
            var result = Calculate.GetSquareTriangle(firstSide, secondSide, thrirdSide);

            // Assert 
            Assert.AreEqual(rightAnswer, result);
        }

        [TestMethod]
        public void GetSquareCircleTest()
        {
            // Arrange
            var radius = 10;
            var rightAnswer = 314;
            //Act
            var result = (int)Calculate.GetSquareCircle(radius);

            // Assert 
            Assert.AreEqual(rightAnswer, result);
        }

    }
}
