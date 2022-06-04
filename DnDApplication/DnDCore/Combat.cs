using DnDCore.Interfaces;

namespace DnDCore
{
    public static class Combat
    {
        #region Player Attacking Methods
        public static int AttackEnemy(IPlayer player)
        {
            Console.WriteLine($"{player.Name} roll for damage: ");
            var userInput = Console.ReadLine();
            var damage = ConvertDamageToInt(userInput);
            return damage;
        }
        public static int ConvertDamageToInt(string result)
        {
            if (string.IsNullOrWhiteSpace(result))
            {
                throw new NullReferenceException();
            }
            else
            {
                return Convert.ToInt32(result);
            }
            
        }
        #endregion

        #region Player Taking Damage Methods
        #endregion
    }
}
