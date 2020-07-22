using UnityEngine;

namespace LearningPower.LearningPatterns.Prototype
{
    /// <summary>
    /// This class it's for test the Prototype pattern
    /// </summary>
    public class WeaponTester : MonoBehaviour
    {
        [SerializeField] private Weapon _currentWeapon;
        [SerializeField] private Target _target;

        private void Update()
        {
            if(Input.GetButtonDown("Fire1"))
                _currentWeapon.Attack(_target);
        }
    }
}