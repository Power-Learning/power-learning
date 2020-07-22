using UnityEngine;

namespace LearningPower.Prototype
{
    /// <summary>
    /// This class implements the Prototype pattern
    /// using different types of WeaponData that it's cloned to set different values
    /// </summary>
    public class Weapon : MonoBehaviour
    {
        [SerializeField] private WeaponData _weaponData;
        [SerializeField] private Transform _weaponAttach;
        private GameObject _model;

        private void OnEnable()
        {
            if(_model != null)
                Destroy(_model);

            if (_weaponData.model != null)
            {
                _model = Instantiate(_weaponData.model, _weaponAttach, false);
            }
        }

        public void Attack(Target target)
        {
            string message = string.IsNullOrEmpty(_weaponData.message) ? "hit" : _weaponData.message;

            if(_weaponData.damage > 0)
                target.TakeDamage(_weaponData.damage, message);
            if(_weaponData.stunDuration > 0)
                target.Stun(_weaponData.stunDuration, message);
            if (_weaponData.freezeDuration > 0)
                target.Freeze(_weaponData.freezeDuration, message);

            
            Debug.Log("You" + message + " " + target.name);
        }
    }
}