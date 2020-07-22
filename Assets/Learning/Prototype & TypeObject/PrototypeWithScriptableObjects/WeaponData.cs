using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LearningPower.Prototype
{
    /// <summary>
    /// This ScriptableObject contains the data to clone for the Prototype pattern
    /// </summary>
    [CreateAssetMenu(menuName = "Weapon Data")]
    public class WeaponData : ScriptableObject
    {
        public int damage;
        public string message;
        public GameObject model;
        public int stunDuration;
        public int freezeDuration;
    } 
}

