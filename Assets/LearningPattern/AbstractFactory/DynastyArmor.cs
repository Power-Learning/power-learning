using UnityEngine;

namespace LearningPattern.AbstractFactory
{
    /// <summary>
    /// Concrete product
    /// </summary>
    public class DynastyArmor : IArmor
    {
        public string Item()
        {
            return "Dynasty armor";
        }
    }
}