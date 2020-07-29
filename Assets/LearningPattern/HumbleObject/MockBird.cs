using UnityEngine;

namespace LearningPattern.HumbleObject
{
    public class MockBird : IBird
    {
        public Vector3 Position { get; set; }
        public float MaxHeight { get; set; }
        public float MinHeight { get; set; }
    }
}