﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IDGS903_BD.Models
{
	public class Alumnos
	{

		public int Id { get; set; }
		[Required]
		[StringLength(100)]
		public string Nombre { get; set; }
		[Required]
		[StringLength(100)]
		public string Apellidos { get; set; }
		public string Correo { get; set; }

	}
}