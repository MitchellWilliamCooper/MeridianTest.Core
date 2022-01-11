using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Meridian.Example.Core.EF
{
	public class DocumentsContext : DbContext
	{
		public DocumentsContext(DbContextOptions options) : base(options)
		{
		}

		public virtual DbSet<DocumentType> DocumentTypes { get; set; }
		public virtual DbSet<Site> Sites { get; set; }
	}

	public class DocumentType
	{
		public int Id { get; set; }
		public string Name { get; set; }
	}

	public class Site
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Code { get; set; }
	}
}
