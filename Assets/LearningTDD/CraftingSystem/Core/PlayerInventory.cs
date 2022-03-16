using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace LearningTDD.CraftingSystem.Core
{
    public class PlayerInventory : MonoBehaviour, IInventory
    {
        public List<ItemContainer> itemsContainer;
        public RecipeData recipeData;
        private Crafter _crafter;
        public ItemContainer animalBone;
        private void Awake()
        {
            _crafter = new Crafter();
            itemsContainer = new List<ItemContainer> {animalBone};
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.A))
                _crafter.Craft(recipeData, this);
        }

        public void AddItem(ItemContainer item)
        {
            itemsContainer.Add(item);
        }

        public void RemoveItem(int itemId)
        {
            //var itemIndex = itemsContainer.IndexOf(item);

            var itemToRemove = itemsContainer.Where(i => i.item.itemId == itemId).ToList();
            foreach (var item in itemToRemove)
            {
                item.quantity--;
            }
        }
    }
}