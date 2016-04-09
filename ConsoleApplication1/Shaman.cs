using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
   public class Shaman:Character
    {
        public Shaman(int hp, int mp, int dmg)
        {
            this.Hp = hp;
            this.Mp = mp;
            this.Dmg = dmg;
        }
    }
}
