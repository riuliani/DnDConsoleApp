using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCore.Interfaces
{
    public interface IPlayer
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int DamageDone { get; set; }
        public int DamageTaken { get; set; }
    }
}
