using UnityEngine;

namespace LearningPattern.Strategy
{
    /// <summary>
    /// This class implements the SummonBehaviour strategy for FrenzySkill
    /// </summary>
    public class FrenzySkill : Skill
    {
        private GameObject _frenzyPrefab;

        public FrenzySkill()
        {
            _frenzyPrefab = (GameObject) Resources.Load("FrenzySkill");
            _skillBehaviour = new SummonBehaviour(_frenzyPrefab);
        }
    }
}