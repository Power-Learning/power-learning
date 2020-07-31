namespace LearningPattern.AbstractFactory
{

    /// <summary>
    /// Abstract factory
    /// </summary>
    public interface ICharacterFactory
    {
        IWeapon GetWeapon();
        IArmor GetArmor();
    }
    
    /// <summary>
    /// This is the concrete product that inherits from ICharacterFactory
    /// and implements the factory products
    /// </summary>
    public class Warrior : ICharacterFactory
    {
        public IWeapon GetWeapon()
        {
            return new Sword();
        }

        public IArmor GetArmor()
        {
            return new DynastyArmor();
        }
    }
}