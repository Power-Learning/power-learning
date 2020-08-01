using UnityEngine;

namespace LearningPattern.Strategy
{
    /// <summary>
    /// This class is the concrete SkillUser.
    /// In the Start, add the 2 skills that we've made before, and put their
    /// corresponding keys to be Alpha 1 and Alpha 2 respectively.
    /// </summary>
    public class FPSPlayer : SkillUser
    {
        [SerializeField] private KeyCode _missileKey;
        [SerializeField] private KeyCode _elusionKey;
        
        private void Start()
        {
            AddSkillAndKey(new FrenzySkill(), _missileKey);
            AddSkillAndKey(new ElusionSkill(), _elusionKey);
        }

        private void Update()
        {
            ListenToPlayerInput();
        }
    }
}