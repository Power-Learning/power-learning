using System.Collections.Generic;
using NUnit.Framework;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

namespace LearningTDD.CraftingSystem.CraftingSystemTests
{
    public class ShouldCraft
    {
        private PlayerInventory _playerInventory;
        private Crafter _crafter;
        public Material charcoal;
        
        [SetUp]
        public void SetUp()
        {
            _playerInventory = new PlayerInventory();
            _crafter = new Crafter();
        }


        [Test]
        public void
            should_player_request_npc_crafter_a_dynasty_sword_creation_and_crafter_should_validate_if_player_have_all_items_and_notify()
        {
            // Given
         
            /*var coal = new Mat();
            var steel = new Mat();
            var goldbar = new Mat();*/
            
            _playerInventory.playerMaterials = new Dictionary<Materials, int>()
            {
                {Materials.Charcoal, 30}, {Materials.Steel, 5}, {Materials.Thread, 15}
            };
           
            var dynastySwordRecipe = new Recipe
            {
                materials = new Dictionary<Materials, int>()
                {
                    {Materials.Charcoal, 30}, {Materials.Steel, 5}, {Materials.Thread, 15}
                }
            };

            // When
            var craftResult = _crafter.Craft(dynastySwordRecipe, _playerInventory);
            
            // Then
            Assert.IsTrue(craftResult);

        }
    }

    public class PlayerInventory
    {
        public Dictionary<Materials, int> playerMaterials;
    }

    public class Crafter
    {
        public bool Craft(Recipe recipe, PlayerInventory playerInventory)
        {
            foreach (var material in recipe.materials)
            {
                foreach (var playerMats in playerInventory.playerMaterials)
                {
                    if (material.Key == playerMats.Key)
                    {
                        if (material.Value < playerMats.Value) continue;
                        Debug.Log("Sword created!");
                        return true;
                    }

                    Debug.Log("You don't have necessary items");
                    return false;
                }
            }
            return false;
        }
    }
    public class Recipe
    {
        public Dictionary<Materials, int> materials;
    }

    public class Mat
    {
        public string matName;
    }

    public enum Materials
    {
        Coal = 0,
        AnimalBone = 1,
        Thread = 2,
        AnimalSkin = 3,
        Charcoal = 4,
        MithrilOre = 5,
        Varnish = 6,
        Steel = 7
    } 
}
