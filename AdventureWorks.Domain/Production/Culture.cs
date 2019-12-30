﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AdventureWorks.Domain.Production
{
    public class Culture : EntityBase
    {
	    [Key]
        public string CultureId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ProductModelProductDescriptionCulture> ProductModelProductDescriptionCulture { get; set; } = new HashSet<ProductModelProductDescriptionCulture>();
    }
}
