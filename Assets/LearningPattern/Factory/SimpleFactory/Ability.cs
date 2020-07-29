using UnityEngine;

namespace LearningPattern.Factory.SimpleFactory
{
    /// <summary>
    /// Here implements a simple factory creating classes from a super-class Ability
    /// </summary>
    public abstract class Ability
    {
        public abstract void Process();
    }
    
    public class SimpleHeal : Ability
    {
        public override void Process()
        {
            Debug.Log("Healing from factory");
        }
    }
    
    public class SimpleFire : Ability
    {
        public override void Process()
        {
            Debug.Log("Firing from factory");
        }
    }

    public class AbilityFactory
    {
        public Ability GetAbility(string ability)
        {
            switch (ability)
            {
                case "heal":
                    return new SimpleHeal();
                    break;
                case "fire":
                    return new SimpleFire();
                break;
                default:
                    return null;
            }
        }
    }
}