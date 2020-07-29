namespace LearningPattern.HumbleObject
{
    using UnityEngine;
    
    public class BirdController
    {
        private IBird _bird;

        public BirdController(IBird bird)
        {
            _bird = bird;
        }
        
        public void Move(float vertical)
        {
            _bird.Position += Vector3.up * vertical;
            if(_bird.Position.y > _bird.MinHeight)
                _bird.Position = new Vector3(_bird.Position.x, _bird.MaxHeight, _bird.Position.z);
            if(_bird.Position.y < _bird.MinHeight)
                _bird.Position = new Vector3(_bird.Position.x, _bird.MinHeight, _bird.Position.z);
        }
    }
}