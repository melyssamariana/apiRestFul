using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Organize.API.Domain.Models;
using Organize.API.Domain.Services;

namespace Organize.API.Controllers
{
	[Route("/api/[controller]")]
	public class CategoriasController : Controller
	{
		private readonly ICategoriaService _categoriaService;
		public CategoriasController(ICategoriaService categoriaService)
		{
			_categoriaService = categoriaService;
		}

		[HttpGet]
		public async Task<IEnumerable<CategoriasController>> GetAllAsync()
		{
			var categorias = await _categoriaService.ListAsync();
			return categorias;
		}

	}
}
