using UnityEngine;

namespace LearningPattern.AbstractFactory
{
    /// <summary>
    /// This class it's the client of the factory
    /// </summary>
    public class PlayerController : MonoBehaviour
    {
        private ICharacterFactory _iCharacter;

        private void Update()
        {
            if (Input.GetKey(KeyCode.A))
            {
                _iCharacter = new Warrior();
                string warriorArmor = _iCharacter.GetArmor().Item();
                Debug.Log(warriorArmor);
            }

            if (Input.GetKey(KeyCode.D))
            {
                _iCharacter = new Warrior();
                string warriorWeapon = _iCharacter.GetWeapon().Item();
                Debug.Log(warriorWeapon);
            }
        }
    }
}