using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCore
{
    public static class Validation
    {
        public static bool CheckUserInput(string result)
        {
            if (string.IsNullOrWhiteSpace(result))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int ConvertStringToInt(bool result, string userInput)
        {
            if (result == true)
            {
                throw new ArgumentNullException();
            }
            else
            {
                var damage = Convert.ToInt32(userInput);
                return damage;
            }
        }
    }
}
