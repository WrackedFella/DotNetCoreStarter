﻿using AdventureWorks.Core;
using System;
using System.Collections.Generic;

namespace AdventureWorks.Dal.Sales
{
	public class CurrencyRate : EntityBase
	{
		public int CurrencyRateId { get; set; }
		public DateTime CurrencyRateDate { get; set; }
		public string FromCurrencyCode { get; set; }
		public string ToCurrencyCode { get; set; }
		public decimal AverageRate { get; set; }
		public decimal EndOfDayRate { get; set; }

		public virtual Currency FromCurrencyCodeNavigation { get; set; }
		public virtual Currency ToCurrencyCodeNavigation { get; set; }
		public virtual ICollection<SalesOrderHeader> SalesOrderHeader { get; set; } = new HashSet<SalesOrderHeader>();
	}
}
