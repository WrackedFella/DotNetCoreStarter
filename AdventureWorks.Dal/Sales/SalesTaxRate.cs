﻿using AdventureWorks.Core;
using AdventureWorks.Dal.Person;
using System;

namespace AdventureWorks.Dal.Sales
{
	public class SalesTaxRate : EntityBase
	{
		public int SalesTaxRateId { get; set; }
		public int StateProvinceId { get; set; }
		public byte TaxType { get; set; }
		public decimal TaxRate { get; set; }
		public string Name { get; set; }
		public Guid Rowguid { get; set; }

		public virtual StateProvince StateProvince { get; set; }
	}
}