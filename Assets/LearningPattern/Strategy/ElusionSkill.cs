using UnityEngine;

namespace LearningPattern.Strategy
{
    /// <summary>
    /// This class implements the ElusioBehaviour strategy for ElusionSkill 
    /// </summary>
    public class ElusionSkill : Skill
    {
        [SerializeField] private GameObject _elusionPrefab;
        
        public ElusionSkill()
        {
            _elusionPrefab = (GameObject) Resources.Load("ElusionSkill");
            _skillBehaviour = new BlinkBehaviour(_elusionPrefab);
        }
    }
}