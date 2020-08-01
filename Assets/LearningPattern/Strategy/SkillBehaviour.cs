using System.Collections;
using UnityEngine;

namespace LearningPattern.Strategy
{
    /// <summary>
    /// This is the base class that defines the strategies methods
    /// </summary>
    public abstract class SkillBehaviour : MonoBehaviour
    {
        public abstract void TriggerActiveEffect(SkillUser skillUser);
        protected internal abstract void TriggerPassiveEffect(SkillUser skillUser);
        protected abstract void KillPrefab(GameObject prefab);
    }
}