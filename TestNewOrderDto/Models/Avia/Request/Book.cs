namespace Contracts.Avia;
public class Book
{
    public string OfferID { get; set; }
    public List<Passenger> Passengers { get; set; }
    public List<Contact> Contacts { get; set; }
    public string Provider { get; set; }
    public string ExtraJSON { get; set; }

    public void Validate()
    {
        Passengers.ForEach(e => e.Validate());
        Contacts.ForEach(e => e.Validate());
    }
}
