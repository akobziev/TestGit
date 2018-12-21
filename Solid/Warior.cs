using System;
using System.Collections.Generic;
using System.Text;

namespace Solid
{
    class Warior
    {
        public IWeapon Weapon { get; set; }

        public Warior(IWeapon weapon)
        {
            Weapon = weapon;
        }

        public void Kill()
        {
            Weapon.Kill();
        }
    }
}
