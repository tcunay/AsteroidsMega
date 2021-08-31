using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsteroidsMega.Weapons.Abstract
{
    public interface IWeapon
    {
        public IAmmo Ammo { get; }

        public void Shoot();
    }
}
