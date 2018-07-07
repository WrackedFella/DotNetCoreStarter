﻿using AdventureWorks.Core;
using AdventureWorks.Dal.Person;
using System;
using System.Collections.Generic;

namespace AdventureWorks.Dal.Sales
{
	public class SalesTerritory : EntityBase
	{
		public int TerritoryId { get; set; }
		public string Name { get; set; }
		public string CountryRegionCode { get; set; }
		public string Group { get; set; }
		public decimal SalesYtd { get; set; }
		public decimal SalesLastYear { get; set; }
		public decimal CostYtd { get; set; }
		public decimal CostLastYear { get; set; }
		public Guid Rowguid { get; set; }

		public virtual CountryRegion CountryRegionCodeNavigation { get; set; }
		public virtual ICollection<Customer> Customer { get; set; } = new HashSet<Customer>();
		public virtual ICollection<SalesOrderHeader> SalesOrderHeader { get; set; } = new HashSet<SalesOrderHeader>();
		public virtual ICollection<SalesPerson> SalesPerson { get; set; } = new HashSet<SalesPerson>();
		public virtual ICollection<SalesTerritoryHistory> SalesTerritoryHistory { get; set; } = new HashSet<SalesTerritoryHistory>();
		public virtual ICollection<StateProvince> StateProvince { get; set; } = new HashSet<StateProvince>();
	}
}