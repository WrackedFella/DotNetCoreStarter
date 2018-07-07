﻿using AdventureWorks.Core;
using System.Collections.Generic;

namespace AdventureWorks.Dal.Production
{
	public class ProductPhoto : EntityBase
	{
		public int ProductPhotoId { get; set; }
		public byte[] ThumbNailPhoto { get; set; }
		public string ThumbnailPhotoFileName { get; set; }
		public byte[] LargePhoto { get; set; }
		public string LargePhotoFileName { get; set; }

		public virtual ICollection<ProductProductPhoto> ProductProductPhoto { get; set; } = new HashSet<ProductProductPhoto>();
	}
}