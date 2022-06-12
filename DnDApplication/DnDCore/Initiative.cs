using DnDCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCore
{
    public class Initiative
    {
        private int initiativeRoll;
        private string playerName;
        public Initiative(int roll, IPlayer player)
        {
            initiativeRoll = roll;
            playerName = player.Name;
        }
        public Dictionary<string,int> AddRolesTolist(int initiativeRoll, string playerName)
        {
            var initRollDictionary = new Dictionary<string,int>();
            initRollDictionary.Add(playerName, initiativeRoll);

            return initRollDictionary;
        }

        public void DisplayOrderFromLargestToSmallest(Dictionary<string, int> initRollDictionary)
        {
            var result = initRollDictionary.OrderBy(x => x.Key);
            var displayResult = result.ToDictionary((keyItem) => keyItem.Key, (valueItem) => valueItem.Value);
            Console.WriteLine("All initiative rolls: ");
            foreach (var item in displayResult)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
        }
    }
}
