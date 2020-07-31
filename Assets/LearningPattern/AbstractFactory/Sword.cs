using UnityEngine;

namespace LearningPattern.AbstractFactory
{
    /// <summary>
    /// Concrete product
    /// </summary>
    public class Sword : IWeapon
    {
        public string Item()
        {
            return "Sword";
        }
    }
}