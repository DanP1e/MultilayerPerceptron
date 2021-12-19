namespace MultilayerPerceptron.Core.Math
{
    public interface IActivationFunction
    {
         float GetDerivative(float _in);
         float GetSimple(float _in);
    }
}