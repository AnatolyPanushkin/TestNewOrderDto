namespace Contracts.Avia
{
    public class IdentityDoc : IValidatable
    {
        public string Surname{ get; set; }
        public string DocNumber { get; set; }
        public string TypeCode { get; set; }
        public string IssueCountryCode { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime? ExpiryDate { get; set; }

        public void Validate()
        {
            if (Surname == "")
                throw new InvalidDataException("Фамилия не корректна");
            if (DocNumber == "")
                throw new InvalidDataException("Код документа  не корректен");
            if (DateTime.Now < IssueDate)
                throw new InvalidDataException("Дата выдачи документа не корректна");
            if (ExpiryDate != null)
                if(ExpiryDate < DateTime.Now)
                throw new InvalidDataException("Дата окончаня срока дейтсвия документа не корректна");
        }
    }
}
