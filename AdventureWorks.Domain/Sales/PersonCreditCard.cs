﻿using System.ComponentModel.DataAnnotations;
using AdventureWorks.Domain.Core;

namespace AdventureWorks.Domain.Sales
{
    public class PersonCreditCard  : EntityBase
    {
	    [Key]
        public int BusinessEntityId { get; set; }
        [Key]
        public int CreditCardId { get; set; }
        
        public virtual Person.Person BusinessEntity { get; set; }
        public virtual CreditCard CreditCard { get; set; }
    }
}
