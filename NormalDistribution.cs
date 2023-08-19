using System;

public class NormalDistribution {

    private readonly float _mean;
    private readonly float _standardDeviation;

    private Random _random;

    public NormalDistribution(float mean, float standardDeviation) {
        _mean = mean;
        _standardDeviation = standardDeviation;

        _random = new Random();
    }

    //one line function: private float GetRandomOverNormalDistribution(float mean, float standardDeviation) => standardDeviation * -0.6266570687f * Mathf.Log((1 / Random.value) - 1) + mean;

    public float GetRandomValue() {
        double randomNumber = _random.NextDouble();

        float z = (float) (-0.6266570687 * Math.Log((1 / randomNumber) - 1));
        return _standardDeviation * z + _mean;
    }

    public float GetRandomValueClamped(float min, float max) {
        float randomOverNormalDistribution = GetRandomValue();

        return Math.Clamp(randomOverNormalDistribution, min, max);
    }

}
