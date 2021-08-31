using AsteroidsMega.Properties.Abstract;

namespace AsteroidsMega.Weapons.Abstract
{
    public interface IAmmo
    {
        public IDamagePolicy DamagePolicy { get; }
        public int Damage { get; }
    }
}
