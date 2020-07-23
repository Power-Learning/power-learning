using UnityEngine;

namespace LearningPattern.Command
{
    /// <summary>
    /// This interface defines the MoveFromTo method to move the entities
    /// </summary>
    public interface IEntity
    {
        Transform transform { get; }

        void MoveFromTo(Vector3 startPosition, Vector3 endPosition);
    }
}