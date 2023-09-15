namespace Contracts.Payment
{
    public class RegistryOrder
    {
        /// <summary>
        /// Сумма заказа в минимальных единицах Валюты. minimum: 0 maximum: 999999999999999
        /// </summary>
        public double Amount { get; set; }

        /// <summary>
        /// Дата/время формирования заказа. example: "2021-03-31T10:53:01Z"
        /// </summary>
        public DateTime OrderCreateDate { get; set; }

        /// <summary>
        /// ID заказа в АС ППРБ.Карты example: "d06112b97ed94215b77714e11c340c7b"
        /// </summary>
        public string OrderId { get; set; }

        /// <summary>
        /// Статус заказа. enum: ["PAID", "CREATED", "REVERSED", "REFUNDED", "REVOKED", "DECLINED", "EXPIRED", "AUTHORIZED", "CONFIRMED", "ON_PAYMENT"]
        /// </summary>
        public string OrderState { get; set; }
    }
}