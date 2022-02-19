using UnityEngine;
using UnityEngine.UI;

namespace LearningTDD.PokemonTournament.Core
{
    public class PokemonView : MonoBehaviour
    {
        [SerializeField] private Image _mpBar;
        [SerializeField] private Button _attackButton;
        [SerializeField] private InputField _attackCommandsInput;
        private Pokemon _pokemon;

        private void Awake()
        {
            _pokemon = new Pokemon();
            _mpBar.fillAmount = _pokemon.CurrentMP;
            _attackButton.onClick.AddListener(PokemonAttack);
        }

        private void PokemonAttack()
        {
            var commands = _attackCommandsInput.text.ToUpper().ToCharArray();
            _pokemon.Attack(commands);
            
            _mpBar.fillAmount = (float)_pokemon.CurrentMP / 100;
        }
    }
}