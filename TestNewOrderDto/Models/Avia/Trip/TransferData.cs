namespace Contracts.Avia;
public class TransferData
{
    public List<Trip> Trips { get; set; }
    public Meta Meta { get; set; }

    public static TransferData operator +(TransferData a, TransferData b)
    {
        a.Trips.AddRange(b.Trips);
        a.Meta.Prices = new()
        {
            Min = a.Meta.Prices.Min < b.Meta.Prices.Min ? a.Meta.Prices.Min : b.Meta.Prices.Min,
            Max = a.Meta.Prices.Max > b.Meta.Prices.Max ? a.Meta.Prices.Max : b.Meta.Prices.Max
        };
        a.Meta.TransportNodes.Arrivals.AddRange(b.Meta.TransportNodes.Arrivals);
        a.Meta.TransportNodes.Arrivals = a.Meta.TransportNodes.Arrivals.Distinct().ToList();
        a.Meta.TransportNodes.Departures.AddRange(b.Meta.TransportNodes.Departures);
        a.Meta.TransportNodes.Departures = a.Meta.TransportNodes.Departures.Distinct().ToList();
        a.Meta.Carriers.AddRange(b.Meta.Carriers);
        a.Meta.Carriers.Distinct().ToList();
        a.Meta.Baggage = a.Meta.Baggage.Union(b.Meta.Baggage);
        a.Meta.Providers = a.Meta.Providers.Union(b.Meta.Providers);
        return a;
    }
}
