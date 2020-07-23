using UnityEngine;

namespace LearningPattern.Command
{
    /// <summary>
    /// This class implements a scale command for an entity
    /// </summary>
    public class ScaleCommand : Command
    {
        private readonly float _scaleFactor;

        public ScaleCommand(IEntity entity, float scaleDirection) : base(entity)
        {
            _scaleFactor = scaleDirection == 1f ? 1.1f : 0.0f;
        }

        public override void Execute()
        {
            _entity.transform.localScale *= _scaleFactor;
        }

        public override void Undo()
        {
            _entity.transform.localScale /= _scaleFactor;
        }
    }
}