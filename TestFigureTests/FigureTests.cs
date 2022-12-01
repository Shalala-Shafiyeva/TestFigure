using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace Figure.Tests
{
    [TestClass()]
    public class FigureTests
    {
        private static readonly object[] _points = new object[]
        {
            new object[] { new List<Point>{
                new Point(1,1),
                new Point(2,2),
                new Point(3,3)
                }
            }
        };

        [TestCaseSource("_points")]
        public void MoveFigureTest(List<Point> points)
        {
            var copiedPoints = points.Select(p => new Point(p.CoordinateX, p.CoordinateY)).ToList();
            int moveToX = 3;
            int moveToY = 3;
            Triangle triangle = new Triangle(copiedPoints);
            triangle.MoveFigure(3, 3);
            for (int i = 0; i < triangle.Points.Count; i++)
            {
                Assert.AreEqual(triangle.Points[i].CoordinateX, points[i].CoordinateX + moveToX);
                Assert.AreEqual(triangle.Points[i].CoordinateY, points[i].CoordinateY + moveToY);
            }

        }
    }
}