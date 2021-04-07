using Carrefour_Projeto.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Carrefour_Projeto.Domain.Entities
{
    public class Product : AuditableBaseEntity
    {
        public string Name { get; set; }
        public string Barcode { get; set; }
        public string Description { get; set; }
        public decimal Rate { get; set; }
    }
}
