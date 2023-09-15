using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Models.SoldedTickets
{
    public class FilterModel : IValidatable
    {
        public int? OrderStatus { get; set; }
        public string? Provider { get; set; }
        public int? MinPrice { get; set; }
        public int? MaxPrice { get; set; }
        public string? Text { get; set; }

        public void Validate()
        {
            if (OrderStatus != null && OrderStatus < 0)
                throw new InvalidDataException("Неверный статутус");
            if(MinPrice != null && MinPrice < 0)
                throw new InvalidDataException("Минимальная цена ниже 0");
            if (MaxPrice != null && MaxPrice < 0)
                throw new InvalidDataException("Максимальная цена ниже 0");
            if (MaxPrice != null && MaxPrice != null && MaxPrice < MinPrice)
                throw new InvalidDataException("Максимальная цена ниже минимальной");
            if(!String.IsNullOrEmpty(Text) && Text.Contains("+"))
                throw new InvalidDataException("Номер содержит '+'");
        }
    }
}
