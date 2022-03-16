namespace LearningTDD.CraftingSystem.Core
{
    public interface IInventory
    {
        void AddItem(ItemContainer item);
        void RemoveItem(int itemId);
    }
}