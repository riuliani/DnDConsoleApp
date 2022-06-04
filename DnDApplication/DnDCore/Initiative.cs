using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCore
{
    public class Initiative
    {        
        public void AddRolesTolist(int initiativeRoll)
        {
            var initRollList = new List<int>();
            initRollList.Add(initiativeRoll);
        }

        public void DisplayOrderFromLargestToSmallest(List<string> initRollList)
        {
            initRollList.Reverse();
            foreach (var initRoll in initRollList)
            {
                Console.WriteLine($"{initRoll}");
            }
        }
    }
}
