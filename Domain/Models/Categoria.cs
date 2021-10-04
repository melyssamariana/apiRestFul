﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


//Plain Old CLR Object (POCO)
namespace Organize.API.Domain.Models
{
	public class Categoria
	{
		public int Id { get; set; }

		public string Nome { get; set; }

		public IList<Produto> Produtos { get; set; } = new List<Produto>();
	}
}
