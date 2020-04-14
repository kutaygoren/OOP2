using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kahhve.API.Domain.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Marka { get; set; }
        public short QuantityInPackage { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public EUnitOfMeasurement UnitOfMeasurement { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
