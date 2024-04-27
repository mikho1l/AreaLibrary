using AreaLibrary;

namespace AreaTest
{
    public class Tests
    {
        double circleRadius = 10;
        double firstSideTriangle = 3;
        double secondSideTriangle = 4;
        double thirdSideTriangle = 5;
        double ExpectedTriangleArea = 6;
        double WrongCircleRadius = 0;
        double WrongFirstSideTriangle = 1;
        double WrongSecondSideTriangle = 2;
        double WrongThirdSideTriangle = 3;
        [Test]
        public void CircleCreate()
        {
            double radius = circleRadius;
            var circle = new Circle(radius);
            Assert.That(circle.Radius, Is.EqualTo(radius));
        }
        [Test]
        public void TriangleCreate()
        {
            double firstSide = firstSideTriangle;
            double secondSide = secondSideTriangle;
            double thirdSide = thirdSideTriangle;
            var triangle = new Triangle(firstSide, secondSide, thirdSide);
            Assert.That(firstSide, Is.EqualTo(triangle.FirstSide));
            Assert.That(secondSide, Is.EqualTo(triangle.SecondSide));
            Assert.That(thirdSide, Is.EqualTo(triangle.ThirdSide));
        }
        [Test]
        public void CircleArea()
        {
            double radius = circleRadius;
            var circle = new Circle(radius);
            Assert.That(circle.GetArea(), Is.EqualTo(Math.PI * radius * radius));
        }
        [Test]
        public void TriangleArea()
        {
            double firstSide = firstSideTriangle;
            double secondSide = secondSideTriangle;
            double thirdSide = thirdSideTriangle;
            var triangle = new Triangle(firstSide, secondSide, thirdSide);
            Assert.That(triangle.GetArea(), Is.EqualTo(ExpectedTriangleArea));
        }
        public void WrongCircleInitialize()
        {
            var radius = WrongCircleRadius;
            var circle = new Circle(radius);
        }
        [Test]
        public void CircleInitializeException()
        {
            var ex = Assert.Throws<ArgumentException>(
            () => WrongCircleInitialize());
        }
        public void WrongTriangleInitialize()
        {
            var firstSide = WrongFirstSideTriangle;
            var secondSide = WrongSecondSideTriangle;
            var thirdSide = WrongThirdSideTriangle;
            var triangle = new Triangle(firstSide, secondSide, thirdSide);
        }
        [Test]
        public void TriangleInitializeException()
        {
            var ex = Assert.Throws<ArgumentException>(
            () => WrongTriangleInitialize());
        }
        [Test]
        public void FactoryTestCircle()
        {
            var parameters = new double[] { 3 };
            var shape = ShapeFactory.CreateShape(parameters, ShapeFactory.ShapeType.Circle);
            Assert.That (shape as Circle, Is.Not.Null);
        }
        [Test]
        public void FactoryTestTriangle()
        {
            var parameters = new double[] { 3, 4, 5 };
            var shape = ShapeFactory.CreateShape(parameters, ShapeFactory.ShapeType.Triangle);
            Assert.That(shape as Triangle, Is.Not.Null);
        }
        public void FactoryWrongParam()
        {
            var parameters = new double[] { 3, 4, 5 };
            var shape = ShapeFactory.CreateShape(parameters, ShapeFactory.ShapeType.Circle);
        }
        [Test]
        public void FactoryParamException()
        {
            var ex = Assert.Throws<ArgumentException>(
            () => FactoryWrongParam());
        }
    }
}