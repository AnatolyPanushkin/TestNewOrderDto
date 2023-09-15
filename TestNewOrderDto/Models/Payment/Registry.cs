namespace Contracts.Payment
{
    public class Registry
    {
        /// <summary>
        /// Код ошибки
        /// </summary>
        public IEnumerable<RegistryOrder> RegistryOrders { get; set; }

        /// <summary>
        /// Код ошибки
        /// </summary>
        public string ErrorCode { get; set; }
    }
}