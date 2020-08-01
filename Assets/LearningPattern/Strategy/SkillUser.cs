using System.Collections.Generic;
using UnityEngine;

namespace LearningPattern.Strategy
{
    /// <summary>
    /// This class is the processor to make changes in the BehaviourSkill
    /// </summary>
    public abstract class SkillUser : MonoBehaviour
    {
        [SerializeField] protected List<Skill> _skills = new List<Skill>();
        [SerializeField] protected List<KeyCode> _keys = new List<KeyCode>();

        protected float _speed;
        protected float _damage;

        public float ModifySpeed(int speed)
        {
            return _speed += speed;
        }

        public float Damage(float damage)
        {
            return _damage += damage;
        }

        protected void AddSkillAndKey(Skill newSkill, KeyCode keyCode)
        {
            _skills.Add(newSkill);
            _keys.Add(keyCode);
            newSkill.Initialize(this);
        }

        protected void ListenToPlayerInput()
        {
            for (int i = 0; i < _keys.Count; i++)
            {
                if (Input.GetKeyDown(_keys[i]))
                {
                    _skills[i].Use(this);
                }
            }
        }
    }
}