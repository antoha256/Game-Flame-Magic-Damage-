using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Flame___Magic_Damage_
{
    internal class SwordDamage
    {
        public const int BASE_DAMAGE = 3;
        public const int FLAME_DAMAGE = 2;

        public int Roll;
        public decimal MagicMultiplier = 1M;
        public int FlaimingDamage = 0;
        public int Damage;


        public void CalculateDamage()
        {
            Damage = (int)(Roll* MagicMultiplier) + BASE_DAMAGE + FlaimingDamage;
        }

        public void SetMagic(bool isMagic)
        {
            if (isMagic)
            {
                MagicMultiplier = 1.75M;
            }
            else
            {
                MagicMultiplier = 1M;
            }
            CalculateDamage();
        }

        public void SetFlaming(bool isFlaming)
        {
            CalculateDamage();
            if(isFlaming)
            {
                Damage += FLAME_DAMAGE;
            }
        }

    }
}
