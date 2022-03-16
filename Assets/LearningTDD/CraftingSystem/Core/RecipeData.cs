using System;
using System.Collections.Generic;
using UnityEngine;

namespace LearningTDD.CraftingSystem.Core
{
    [Serializable]
    public class RecipeResult
    {
        public ItemContainer result;
    }
    
    [CreateAssetMenu(fileName = "Recipe", menuName = "CreateNewRecipe", order = 0)]
    public class RecipeData : ScriptableObject
    {
        public string recipeName;
        public List<ItemContainer> recipeMaterials;
        public RecipeResult craftResult;
        public int successRate;
    }
}