namespace Exercism;

class WeighingMachine
{
    public int Precision { get; }
    private double _weight;
    public double Weight 
    {
        get => _weight;
        set => _weight = value >= 0 ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }
    public string DisplayWeight
    {
        get => $"{(Weight - TareAdjustment).ToString($"n{Precision}")} kg";
    }
    public double TareAdjustment { get; set; } = 5;

    public WeighingMachine(int precision)
    {
        Precision = precision;
    }
}