using TMPro;
using UnityEngine;

namespace LearningPower.LearningPatterns.Prototype
{
    /// <summary>
    /// This class represents the target enemy that it's modified by the Prototype pattern
    /// </summary>
    public class Target : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _logText;
        [SerializeField] private Transform _logTextContainer;
        
        public void TakeDamage(int damage, string message)
        {
            TextMeshProUGUI newTextDamage = Instantiate(_logText, _logTextContainer);
            newTextDamage.text = message + " " + damage;
        }

        public void Stun(int stunDuration, string message)
        {
            TextMeshProUGUI newText = Instantiate(_logText, _logTextContainer);
            newText.text =  message + " " + stunDuration;
        }

        public void Freeze(int weaponDataFreezeDuration, string message)
        {
            TextMeshProUGUI newText = Instantiate(_logText, _logTextContainer);
            newText.text =  message + " " + weaponDataFreezeDuration;
        }
    }
}