using System;

namespace MultilayerPerceptron.Core.Math
{
    public static class RandomGenerator
    {
        private static readonly Random _random = new Random();

        public static float NextFloat(float min, float max)
        {
            double val = (_random.NextDouble() * (max - min) + min);
            return (float)val;
        }
    }
}
