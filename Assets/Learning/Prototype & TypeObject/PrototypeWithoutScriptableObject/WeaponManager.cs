using System;
using UnityEngine;

namespace LearningPower.Prototype
{
    /// <summary>
    /// This example implements the Prototype clone through a normal class
    /// </summary>
    public class WeaponManager : MonoBehaviour
    {
        private void Start()
        {
            WeaponStats sword = new WeaponStats();
            WeaponBase weaponSwordCloned = new WeaponBase().Clone() as WeaponBase;

            sword.damage = weaponSwordCloned.damage;
            sword.model = weaponSwordCloned.model;
            sword.freezeDuration = weaponSwordCloned.freezeDuration;
            sword.stunDuration = weaponSwordCloned.freezeDuration;
            
            WeaponStats dagger = new WeaponStats();
            WeaponBase weaponDaggerCloned = new WeaponBase().Clone() as WeaponBase;
            dagger.damage = weaponDaggerCloned.damage;
            dagger.message = weaponDaggerCloned.message;
            dagger.freezeDuration = weaponDaggerCloned.freezeDuration;
            dagger.stunDuration = weaponDaggerCloned.stunDuration;

        }
    }
    
    [Serializable]
    public class WeaponStats : MonoBehaviour
    {
        public int damage;
        public string message;
        public GameObject model;
        public int stunDuration;
        public int freezeDuration;
    }
}