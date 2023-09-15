namespace Contracts.Avia;
public enum OrderOperations
{
    /// <summary>
    /// Операция покупки
    /// </summary>
    Ticket = 0,
    /// <summary>
    /// Операция получения статуса
    /// </summary>
    Get = 1,
    /// <summary>
    /// Операция бронирования
    /// </summary>
    Book = 2,
    /// <summary>
    /// Операция войдирования
    /// </summary>
    Void = 3,
    /// <summary>
    /// Операция возврата
    /// </summary>
    Refund = 4,
    /// <summary>
    /// Операция обмена
    /// </summary>
    Exchange = 5,
    /// <summary>
    /// Операция отмены
    /// </summary>
    Cancel = 6
}