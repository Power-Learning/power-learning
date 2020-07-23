using UnityEngine;

namespace LearningPattern.Command
{
    /// <summary>
    /// This class implements the MoveCommand for RTS movement
    /// </summary>
    public class MoveToCommand : Command
    {
        private Vector3 _destination;
        private Vector3 _originalPosition;
        public MoveToCommand(IEntity entity, Vector3 destination) : base(entity)
        {
            _destination = destination;
        }

        public override void Execute()
        {
            _originalPosition = _entity.transform.position;
            _entity.MoveFromTo(_originalPosition, _destination);
        }

        public override void Undo()
        {
            _entity.MoveFromTo(_entity.transform.position, _originalPosition);
        }
    }
}