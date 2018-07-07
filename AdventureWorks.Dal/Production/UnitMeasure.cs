﻿using AdventureWorks.Core;
using AdventureWorks.Dal.Purchasing;
using System.Collections.Generic;

namespace AdventureWorks.Dal.Production
{
	public class UnitMeasure : EntityBase
	{
		public string UnitMeasureCode { get; set; }
		public string Name { get; set; }

		public virtual ICollection<BillOfMaterials> BillOfMaterials { get; set; } = new HashSet<BillOfMaterials>();
		public virtual ICollection<Product> ProductSizeUnitMeasureCodeNavigation { get; set; } = new HashSet<Product>();
		public virtual ICollection<ProductVendor> ProductVendor { get; set; } = new HashSet<ProductVendor>();
		public virtual ICollection<Product> ProductWeightUnitMeasureCodeNavigation { get; set; } = new HashSet<Product>();
	}
}
