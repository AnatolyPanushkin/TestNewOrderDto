using System;
namespace Contracts.Payment
{
	public class RegistryOrderOperationParam
	{
        /// <summary>
        /// Код авторизации
        /// </summary>
        public string authCode { get; set; }

        /// <summary>
        /// Дата/время совершения операции. example: "2020-03-19T19:00:39Z"
        /// </summary>
        public DateTime operationDateTime { get; set; }

        /// <summary>
        /// Идентификатор операции в АС Банка (ППРБ Ecom). example: "aa8a8779de9e4ca59d3922ed5e5e07fa"
        /// </summary>
        public string operationId { get; set; }

        /// <summary>
        /// Тип операции. enum: ["PAY", "REVERSE", "REFUND", "SBP_PAY_ACKNOWL", "SBP_ACK_ONUS", "SBP_STATUS_OUT", "SBP_CREDIT_IN_RQ", "SBP_REFUND_IN_RQ"]
        /// </summary>
        public string operationType { get; set; }

        /// <summary>
        /// Валюта операции, цифровой код по ISO 4217. example: "643"
        /// </summary>
        public string operationCurrency { get; set; }

        /// <summary>
        /// Сумма операции в минимальных единицах Валюты
        /// </summary>
        public double operationSum { get; set; }

        /// <summary>
        /// RRN операции
        /// </summary>
        public string rrn { get; set; }

        /// <summary>
        /// Код успешности авторизации
        /// </summary>
        public string responseCode { get; set; }
    }
}

