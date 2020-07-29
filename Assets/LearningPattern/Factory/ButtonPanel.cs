using System;
using LearningPattern.Factory.ReflectionFactory;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace LearningPattern.Factory
{
    /// <summary>
    /// This class creates the buttons through the factory classes
    /// finding each type and set the functionality to each button created
    /// </summary>
    public class ButtonPanel : MonoBehaviour
    {
        [SerializeField] private GameObject _buttonPrefab;

        private void OnEnable()
        {
            foreach (string name in AbilityFactory.GetAbilityNames())
            {
                var button = Instantiate(_buttonPrefab, transform, true);
                button.gameObject.name = name + "Button";
                button.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = name;
                SetAbilityName(name, button);
            }
        }

        private void SetAbilityName(string abilityName, GameObject button)
        {
            var ability = AbilityFactory.GetAbility(abilityName);
            button.GetComponent<Button>().onClick.AddListener(ability.Process);
        }
    }
}