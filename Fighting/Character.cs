using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fighting
{
    class Character
    {
        int maxHp, maxMp, atk, def, currentHp, currentMp;
        
        public int getHp()
        {
            return currentHp;        
        }
        public int getMp()
        {
            return currentMp;
        }
        public int getMaxHp()
        {
            return maxHp;
        }
        public int getMaxMp()
        {
            return maxMp;
        }

        public int getAtk()
        {
            return atk;
        }
        public int getDef()
        {
            return def;
        }
        public void setHp(int h)
        {
            if (h >= 0 && h < 10000)
            {
                currentHp = h;   
            }
        }
        public void setMp(int h)
        {
            if (h >= 0 && h < 1000)
            {
                currentMp = h;
            }
        }
        public void setMaxHp(int h)
        {
            maxHp = h;
        }
        public void setmaxMp(int h)
        {
            maxMp = h;
        }
        public void setAtk(int h)
        {
            atk = h;
        }
        public void setDef(int h)
        {
            def = h;
        }
 
    }
}
