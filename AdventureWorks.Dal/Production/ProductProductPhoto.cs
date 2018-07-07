﻿using AdventureWorks.Core;

namespace AdventureWorks.Dal.Production
{
	public class ProductProductPhoto : EntityBase
	{
		public int ProductId { get; set; }
		public int ProductPhotoId { get; set; }
		public bool Primary { get; set; }

		public virtual Product Product { get; set; }
		public virtual ProductPhoto ProductPhoto { get; set; }
	}
}
