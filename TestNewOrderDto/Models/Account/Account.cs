namespace Contracts.Accounts;
public class Account
{
    public int Id { get; set; }
    public string Email { get; set; } = null!;
    public string? AuthToken { get; set; }
    public DateTime? LastVisit { get; set; }
    public int Role { get; set; }
    public string? Name { get; set; }
    public bool IsActive { get; set; }
    public bool UseBallance { get; set; }
    public double Ballance { get; set; }
    public double Tax { get; set; }
}
