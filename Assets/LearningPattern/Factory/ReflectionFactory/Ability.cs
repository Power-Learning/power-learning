using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEngine;

namespace LearningPattern.Factory.ReflectionFactory
{
    /// <summary>
    /// This class creates a Factory pattern with reflection and static
    /// </summary>
    public abstract class Ability
    {
        public abstract  string name { get; }
        public abstract void Process();
    }

    /// <summary>
    /// This class inherits from Ability and implements a heal functionality
    /// </summary>
    public class ReflectionHeal : Ability
    {
        public override string name => "heal";
        
        public override void Process()
        {
            var player = GameObject.FindObjectOfType<PlayerController>();
            player.ShowParticle(0);
            player.Health++;
        }
    }
    
    /// <summary>
    /// This class inherits from Ability and implements a firing functionality
    /// </summary>
    public class ReflectionFire : Ability
    {
        public override string name => "fire";

        public override void Process()
        {
            GameObject.FindObjectOfType<PlayerController>().ShowParticle(1);
        }
    }
    
    /// <summary>
    /// This class inherits from Ability and implements a magical functionality
    /// </summary>
    public class ReflectionMagic : Ability
    {
        public override string name => "magic";

        public override void Process()
        {
            GameObject.FindObjectOfType<PlayerController>().ShowParticle(2);
        }
    }

    /// <summary>
    /// This class get all types of sub-classes derived from Ability by name and with reflection
    /// </summary>
    public static class AbilityFactory
    {
        private static Dictionary<string, Type> _abilitiesByName;
        private static bool _isInitialized = _abilitiesByName != null;

        private static void InitializeFactory()
        {
            if(_isInitialized)
                return;
            
            var abilitiesType = Assembly.GetAssembly(typeof(Ability)).GetTypes()
                .Where(myType => myType.IsClass && !myType.IsAbstract && myType.IsSubclassOf(typeof(Ability)));
            
            // Dictionary for finding these by name later (could be an enum/id instead of string)
            _abilitiesByName = new Dictionary<string, Type>();
            
            // Get the names and put them into the Dictionary
            foreach (var type in abilitiesType)
            {
                var tempEffect = Activator.CreateInstance(type) as Ability;
                _abilitiesByName.Add(tempEffect.name, type);
            }
        }

        /// <summary>
        /// This class get the current ability by name, checks if exists in the Dictionary
        /// and creates and instance
        /// </summary>
        /// <param name="abilityType"></param>
        /// <returns></returns>
        public static Ability GetAbility(string abilityType)
        {
            InitializeFactory();
            
            if (_abilitiesByName.ContainsKey(abilityType))
            {
                Type type = _abilitiesByName[abilityType];
                var ability = Activator.CreateInstance(type) as Ability;
                return ability;
            }
            return null;
        }

        /// <summary>
        /// This class get all existing abilities by names
        /// </summary>
        /// <returns></returns>
        internal static IEnumerable<string> GetAbilityNames()
        {
            Debug.Log("Test");
            InitializeFactory();
            return _abilitiesByName.Keys;
        }
    }
}