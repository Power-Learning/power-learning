using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace LearningTDD.CraftingSystem.Core
{
    public class Crafter
    {
        public Crafter()
        {
        }

        public bool Craft(RecipeData recipe, PlayerInventory playerInventory)
        {
            if (!CanCraft(playerInventory, out var inventoryMaterials)) return false;

            foreach (var recipeMaterial in recipe.recipeMaterials)
            {
                foreach (var pMaterials in inventoryMaterials)
                {
                    if (recipeMaterial.item == pMaterials.item && recipeMaterial.quantity <= pMaterials.quantity)
                    {
                        Debug.Log("Mhmmm i'm trying to craft your item...");
                    }
                    else
                    {
                        Debug.Log("You don't have necessary items");
                        return false;
                    }
                }
            }

            var result = Random.Range(0, 100);
            
            if (result < recipe.successRate)
            {
                Debug.Log("Craft failed!");
                RemoveMaterialsFromInventory(recipe, playerInventory);
                return false;
            }

            Debug.Log($"{recipe.recipeName} crafted successfully!");
            playerInventory.AddItem(recipe.craftResult.result);
            RemoveMaterialsFromInventory(recipe, playerInventory);
            return true;
        }

        private bool CanCraft(PlayerInventory playerInventory, out List<ItemContainer> inventoryMaterials)
        {
            inventoryMaterials = playerInventory.itemsContainer.Where(p => p.item.itemType != ItemType.WEAPON).ToList();

            if (inventoryMaterials.Count >= 1) return true;
            Debug.Log("You don't have necessary items");
            return false;

        }

        private void RemoveMaterialsFromInventory(RecipeData recipeData, PlayerInventory inventory)
        {
            foreach (var t in recipeData.recipeMaterials)
            {
                for (int i = 0; i < t.quantity; i++)
                {
                   inventory.RemoveItem(t.item.itemId);
                }
            }
        }
    }
}