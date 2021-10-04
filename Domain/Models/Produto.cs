﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Organize.API.Domain.Models
{
	public class Produto
	{
		public int Id { get; set; }
		public string Nome { get; set; }
		public short QuantidadePacote { get; set; }
		public EUnidadeMedida UnidadeMedida { get; set; }
		public int CategoriaId { get; set; }
		public Categoria Categoria { get; set; }

	}
}
