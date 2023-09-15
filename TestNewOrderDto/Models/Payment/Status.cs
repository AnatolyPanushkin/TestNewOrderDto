namespace Contracts.Payment;
public enum Status
{
    /// <summary>
    /// ����������� ������
    /// </summary>
    UNKNOWN = 0,
    /// <summary>
    /// ������ ��� � �������� � ������ ���� ���������� �����������
    /// </summary>
    CREATED = 1,
    /// <summary>
    /// � �������� � ������ ���� �������� �������� ������� �� ����� ������/ �������� �������� ������� � ����������(-��) �������� ������
    /// </summary>
    PAID = 2,
    /// <summary>
    /// � �������� � ������ ���� �������� �������� ������/��������� ������. 
    /// </summary>
    REVERSED = 3,
    /// <summary>
    /// � �������� � ������ ���� �������� �������� �������/���������� ��������
    /// </summary>
    REFUNDED = 4,
    /// <summary>
    /// ������� �� ���������� ���������� ��������
    /// </summary>
    REVOKED = 5,
    /// <summary>
    /// ����� ��������
    /// </summary>
    DECLINED = 6,
    /// <summary>
    /// ����� ���� ����� ������ (���������������)
    /// </summary>
    EXPIRED = 7,
    /// <summary>
    /// ��� QR ��� - ������� ������������� ������� �� ���
    /// </summary>
    ON_PAYMENT = 8
}

public static class StatusConverter
{
    /// <summary>
    /// Для QR
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public static Status ToStatus(string value)
    {
        return value.ToUpper() switch
        {
            "CREATED" => Status.CREATED,
            "PAID" => Status.PAID,
            "REVERSED" => Status.REVERSED,
            "REFUNDED" => Status.REFUNDED,
            "REVOKED" => Status.REVOKED,
            "DECLINED" => Status.DECLINED,
            "EXPIRED" => Status.EXPIRED,
            _ => Status.UNKNOWN,
        };
    }
    /// <summary>
    /// Для эквайринга
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public static Status ToStatus(int value)
    {
        return value switch
        {
            0 => Status.CREATED,
            1 => Status.ON_PAYMENT,
            2 => Status.PAID,
            3 => Status.DECLINED,
            4 => Status.REFUNDED,
            6 => Status.DECLINED,
            _ => Status.UNKNOWN,
        };
    }
}



