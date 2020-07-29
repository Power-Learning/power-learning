using NUnit.Framework;

namespace LearningPattern.HumbleObject
{
    public class BirdTest
    {
        [Test]
        public void BirdStopsAtMinHeight()
        {
            IBird bird = new MockBird() {MaxHeight = 3, MinHeight = -3};
            BirdController birdController = new BirdController(bird);
            birdController.Move(-10);
            Assert.AreEqual(-3f, bird.Position.y);
        }
        
        
        [Test]
        public void BirdStopsAtMaxHeight()
        {
            IBird bird = new MockBird() { MaxHeight = 3, MinHeight = -3 };
            BirdController birdController = new BirdController(bird);
            birdController.Move(10f);
            Assert.AreEqual(3f, bird.Position.y);
        }
        
        /*[Test]
        public void BirdsMoveUp1Meter()
        {
            IBird bird = new MockBird() { MaxHeight = 3, MinHeight = -3 };
            BirdController birdController = new BirdController(bird);
            birdController.Move(1f);
            Assert.AreEqual(1f, bird.Position.y);
        }*/
    }
}