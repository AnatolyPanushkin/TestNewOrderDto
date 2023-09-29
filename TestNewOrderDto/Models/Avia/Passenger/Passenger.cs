namespace Contracts.Avia
{
    public class Passenger 
    {
        public string Id { get; set; }
        public DateTime Birthday { get; set; }
        public string GenderCode { get; set; }
        public string TypeCode { get; set; }
        public string Surname { get; set; }
        public string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public IdentityDoc IdentityDoc { get; set; }

        public void Validate()
        {
            if (Birthday > DateTime.Now)
                throw new InvalidDataException("Дата рождения не корректна");
            if (TypeCode != "ADT" && TypeCode != "CNN" && TypeCode != "INF")
                throw new InvalidDataException("Неизвестный код пассажира");
            if (!string.IsNullOrEmpty(MiddleName) && MiddleName.Length < 3)
                throw new InvalidDataException($"Неккоректное отчество пассажира. Если отчество отсутствует, оставьте значение пустым. Текущее значение: '{MiddleName}'");
            IdentityDoc.Validate();
        }
    }
}
