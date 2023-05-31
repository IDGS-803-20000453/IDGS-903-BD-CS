using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace IDGS903_BD.Models
{
	public class AlumnosDbContext:DbContext
	{
		private static string connection = "DefaultConnection";
		public AlumnosDbContext() : base(connection) { }
		public DbSet <Alumnos> Alumnos { get; set; }

	}
}