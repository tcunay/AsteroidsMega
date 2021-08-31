namespace AsteroidsMega.Properties.Abstract
{
    public interface IHealth
    {
        public float CurrentValue { get; }
        public float MaxValue { get; }

        public void TakeDamage(float damage);
    }
}
