namespace Contracts.Payment;

public class Register
{
    /// <summary>
    /// ����� ������
    /// </summary>
    public double Amount { get; set; }
    /// <summary>
    /// ����� ������ ������� ��������
    /// </summary>
    public string? OrderNumber { get; set; }
    /// <summary>
    /// ������ ��� �������� ������
    /// </summary>
    public string? SuccessUrl { get; set; }
    /// <summary>
    /// ������ ��� ���������� ������
    /// </summary>
    public string? FailUrl { get; set; }
    /// <summary>
    /// E-mail �������
    /// </summary>
    public string? Email { get; set; }
    /// <summary>
    /// ������� �������
    /// </summary>
    public string? Phone { get; set; }
}