namespace Contracts.Models.NewAvia;

public class Passenger
{
    public DateTime Birthday { get; set; }
    public string GenderCode { get; set; } = null!;
    public string Surname { get; set; } = null!;
    public string Name { get; set; } = null!;
    public string? Patronymic { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public Document Document { get; set; } = null!;
}
