using NUnit.Framework;

namespace LearningTDD.CITests
{
    public class ShouldSum
    {
        // A Test behaves as an ordinary method
        [Test]
        public void ShouldSumNumbers()
        {
            Assert.AreEqual(4+2,6);
        }
    }
}
