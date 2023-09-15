namespace Contracts.Avia;
public class PriceRange
{
    public PriceRange()
    {
    }
    public PriceRange(double min, double max)
    {
        Min = min;
        Max = max;
    }
    public double Min { get; set; }
    public double Max { get; set; }
}
