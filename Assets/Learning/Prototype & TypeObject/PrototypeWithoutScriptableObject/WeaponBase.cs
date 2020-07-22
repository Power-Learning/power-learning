using System;
using UnityEngine;

namespace LearningPower.LearningPatterns.Prototype
{
    /// <summary>
    /// This class is the base class for Prototype instead use an ScriptableObject
    /// </summary>
    public class WeaponBase : ICloneable
    {
        public int damage;
        public string message;
        public GameObject model;
        public int stunDuration;
        public int freezeDuration;
        
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}