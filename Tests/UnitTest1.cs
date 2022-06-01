using NUnit.Framework;
using static Names.Program;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void Correct()
        {
            double result = Function(new double[] { 1, 0, 4, -5, -6, 0, 10 });
            Assert.That(result, Is.EqualTo(-11));
        }

        [Test]
        public void Fucntion_Should_Throw_On_Empty_Array()
        {
            Assert.Throws<ArgumentException>(() => Function(new double[0]));
        }

        [Test]
        public void Identical_Elements()
        {
            double result = Function(new double[] { 1, 1, 1, 1, 1, 1, 1, 1, 1 });
            Assert.That(result, Is.EqualTo(2));
        }
    }
}