using UnityEngine;

namespace LearningTDD.CraftingSystem.Core
{
    [CreateAssetMenu(fileName = "Item", menuName = "ItemData/CreateNewItem", order = 1)]
    public class Item : ScriptableObject
    {
        public int itemId;
        public string itemName;
        public Sprite itemIcon;
        public GameObject itemPrefab;
        public ItemType itemType;
        
        public virtual void Destroy(){}
    }

    public enum ItemType
    {
        ITEM,
        MATERIAL,
        QUEST_ITEM,
        WEAPON
    }
}