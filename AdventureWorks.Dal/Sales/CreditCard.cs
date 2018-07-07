﻿using AdventureWorks.Core;
using System.Collections.Generic;

namespace AdventureWorks.Dal.Sales
{
	public class CreditCard : EntityBase
	{
		public int CreditCardId { get; set; }
		public string CardType { get; set; }
		public string CardNumber { get; set; }
		public byte ExpMonth { get; set; }
		public short ExpYear { get; set; }

		public virtual ICollection<PersonCreditCard> PersonCreditCard { get; set; } = new HashSet<PersonCreditCard>();
		public virtual ICollection<SalesOrderHeader> SalesOrderHeader { get; set; } = new HashSet<SalesOrderHeader>();
	}
}
