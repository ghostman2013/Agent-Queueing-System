using System;

namespace Agents
{
    public class GaussianRandom : Random
    {
        public GaussianRandom() { }

        public GaussianRandom(int seed) : base(seed) { }

        private double NextGaussian()
        {
            double u1 = 1.0 - base.NextDouble();
            double u2 = 1.0 - base.NextDouble();
            return 0.25 * (Math.Sqrt(-2.0 * Math.Log(u1)) * Math.Sin(2.0 * Math.PI * u2)) + 0.5;
        }

        public override double NextDouble()
        {
            double gaussian = NextGaussian();

            if (gaussian < 0)
            {
                return 0;
            }

            if (gaussian > 1.0)
            {
                return 1.0;
            }

            return gaussian;
        }

        public override int Next(int maxValue)
        {
            return (int)Math.Round(maxValue * NextDouble());
        }

        public override int Next()
        {
            return Next(int.MaxValue);
        }

        public override int Next(int minValue, int maxValue)
        {
            return Next(maxValue - minValue) + minValue;
        }

        public override void NextBytes(byte[] buffer)
        {
            for (int i = 0; i < buffer.Length; ++i)
            {
                buffer[i] = (byte)Next();
            }
        }
    }
}
