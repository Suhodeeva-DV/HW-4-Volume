using System;
using Xunit;

namespace HW_4_Volume.Test
{
    public class UnitTest1
    {
        [Fact]
        public void BoxVolumeTest()
        {
            var box = new Box();
            box.Height = 10;

            double result = box.Volume();

            Assert.Equal(1000, result, 5);
        }

        [Theory]
        [InlineData(30,10)]
        public void AddTest(int boxHeight, int ballRadius)
        {
            var box = new Box();
            var ball = new Ball();

            box.Height = boxHeight;
            ball.Radius = ballRadius;

            Assert.True(box.Add(ball));
        }

        [Theory]
        [InlineData(6, 10)]
        public void CylinderVolumeTest(int radius, int hight)
        {
            var cylinder = new Cylinder();
            cylinder.Radius = radius;
            cylinder.Height = hight;

            double result = cylinder.Volume();

            Assert.Equal(1130.97336, result, 5);
        }

        [Theory]
        [InlineData(6, 10)]
        public void PyramidVolumeTest(int area, int hight)
        {
            var pyramid = new Pyramid();
            pyramid.Area = area;
            pyramid.Height = hight;

            double result = pyramid.Volume();

            Assert.Equal(20, result, 5);
        }

        [Fact]
        public void BallVolumeTest()
        {
            var ball = new Ball();
            ball.Radius = 10;

            double result = ball.Volume();

            Assert.Equal(4188.79, result, 3);
        }
    }
}
