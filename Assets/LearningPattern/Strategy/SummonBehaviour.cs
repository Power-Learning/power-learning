using System.Globalization;
using TMPro;
using UnityEngine;

namespace LearningPattern.Strategy
{
    /// <summary>
    /// Concrete strategy behaviour class
    /// </summary>
    public class SummonBehaviour : SkillBehaviour
    {
        [SerializeField] private GameObject _summonPrefab;
        private readonly GameObject _damageText;
        public SummonBehaviour(GameObject summonPrefab)
        {
            _damageText = GameObject.Find("damageText");
            _summonPrefab = summonPrefab;
        }
        
        public override void TriggerActiveEffect(SkillUser skillUser)
        {
            GameObject newPrefab = Instantiate(_summonPrefab, skillUser.transform);
            _damageText.GetComponent<TextMeshProUGUI>().text = "Damage: " + skillUser.Damage(30f).ToString(CultureInfo.InvariantCulture);
            KillPrefab(newPrefab);
        }

        protected internal override void TriggerPassiveEffect(SkillUser skillUser)
        {
            
        }

        protected override void KillPrefab(GameObject prefab)
        {
            Destroy(prefab, 3f);
        }
    }
}