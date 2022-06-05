using DnDCore.Interfaces;

namespace DnDCore
{
    public static class Combat
    {
        #region Player Attacking Methods
        public static int AttackEnemy(IPlayer player)
        {
            Console.WriteLine($"{player.Name} enter total damage done: ");
            var userInput = Console.ReadLine();
            var isValid = Validation.CheckUserInput(userInput);
            var damage = Validation.ConvertStringToInt(isValid, userInput);
            return damage;
        }
        #endregion

        #region Player Taking Damage Methods
        #endregion
    }
}
