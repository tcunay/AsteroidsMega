namespace AsteroidsMega.Weapons.Abstract
{
    public interface IWeapon
    {
        public IAmmo Ammo { get; }

        public void Shoot();
    }
}
