﻿using System;
using System.ComponentModel.DataAnnotations;
using AdventureWorks.Domain.Core;
using AdventureWorks.Domain.Person;

namespace AdventureWorks.Domain.Sales
{
    public class SalesTaxRate  : EntityBase
    {
	    [Key]
        public int SalesTaxRateId { get; set; }
        public int StateProvinceId { get; set; }
        public byte TaxType { get; set; }
        public decimal TaxRate { get; set; }
        public string Name { get; set; }
        public Guid Rowguid { get; set; }
        
        public virtual StateProvince StateProvince { get; set; }
    }
}
