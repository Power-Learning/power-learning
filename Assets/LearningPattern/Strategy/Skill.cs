using System;

namespace LearningPattern.Strategy
{
    /// <summary>
    /// This is the base class to use the SkillBehaviour
    /// </summary>
    [Serializable]
    public class Skill
    {
        protected int _manaCost;
        protected SkillBehaviour _skillBehaviour;

        public void Initialize(SkillUser user)
        {
            _skillBehaviour.TriggerPassiveEffect(user);
        }

        public void Use(SkillUser user)
        {
            _skillBehaviour.TriggerActiveEffect(user);
        }
    }
}