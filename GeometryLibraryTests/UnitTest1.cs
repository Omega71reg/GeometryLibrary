using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeometryLibrary;

namespace GeometryLibraryTests
{
    [TestClass]
    public class GeometryLibraryTests
    {
        [TestMethod]
        public void CircleAreaTest()
        {
            var circle = new Circle(5);
            Assert.AreEqual(Math.PI * 25, circle.GetArea(), 1e-10);
        }

        [TestMethod]
        public void TriangleAreaTest()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.AreEqual(6, triangle.GetArea(), 1e-10);
        }

        [TestMethod]
        public void RightAngledTriangleTest()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.IsTrue(triangle.IsRightAngled());
        }

        [TestMethod]
        public void ShapeAreaCalculatorTest()
        {
            var circle = new Circle(5);
            var triangle = new Triangle(3, 4, 5);
            var calculator = new ShapeAreaCalculator();

            Assert.AreEqual(Math.PI * 25, calculator.CalculateArea(circle), 1e-10);
            Assert.AreEqual(6, calculator.CalculateArea(triangle), 1e-10);
        }
    }
}