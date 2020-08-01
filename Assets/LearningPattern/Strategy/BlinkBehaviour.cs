using System;
using System.Collections;
using System.Globalization;
using TMPro;
using UnityEngine;

namespace LearningPattern.Strategy
{
    /// <summary>
    /// Concrete strategy behaviour class
    /// </summary>
    [Serializable]
    public class BlinkBehaviour : SkillBehaviour
    {
        [SerializeField] private GameObject _blinkPrefab;
        private readonly GameObject _speedText;
        public BlinkBehaviour(GameObject prefab)
        {
            _speedText = GameObject.Find("speedText");
            _blinkPrefab = prefab;
        }
        
        public override void TriggerActiveEffect(SkillUser skillUser)
        {
            GameObject newPrefab = Instantiate(_blinkPrefab, skillUser.transform);
            _speedText.GetComponent<TextMeshProUGUI>().text = "Speed: " + skillUser.ModifySpeed(35).ToString(CultureInfo.InvariantCulture);
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