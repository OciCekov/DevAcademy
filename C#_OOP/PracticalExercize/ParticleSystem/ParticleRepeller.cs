namespace ParticleSystem
{
    public class ParticleRepeller : Particle
    {
        public int RadiusOfEffect { get; private set; }
        public int ReppelerPower { get; private set; }

        public ParticleRepeller(MatrixCoords position, MatrixCoords speed, uint reppelerPower, uint radiusOfEffect)
            : base(position, speed)
        {
            this.RadiusOfEffect = (int)radiusOfEffect;
            this.ReppelerPower = (int)reppelerPower;
        }

        public override char[,] GetImage()
        {
            return new char[,] { { '-' } };
        }
    }
}