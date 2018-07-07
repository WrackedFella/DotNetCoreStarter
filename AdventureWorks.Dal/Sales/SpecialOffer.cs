﻿using AdventureWorks.Core;
using System;
using System.Collections.Generic;

namespace AdventureWorks.Dal.Sales
{
	public class SpecialOffer : EntityBase
	{
		public int SpecialOfferId { get; set; }
		public string Description { get; set; }
		public decimal DiscountPct { get; set; }
		public string Type { get; set; }
		public string Category { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
		public int MinQty { get; set; }
		public int? MaxQty { get; set; }
		public Guid Rowguid { get; set; }

		public virtual ICollection<SpecialOfferProduct> SpecialOfferProduct { get; set; } = new HashSet<SpecialOfferProduct>();
	}
}
