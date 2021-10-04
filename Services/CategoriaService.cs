using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Organize.API.Domain.Models;
using Organize.API.Domain.Repositories;
using Organize.API.Domain.Services;

namespace Organize.API.Services
{
	public class CategoriaService : ICategoriaService
	{
		private readonly ICategoriaRepository _categoriaRepository;
		public CategoriaService(ICategoriaRepository categoriaRepository)
		{
			_categoriaRepository = categoriaRepository;
		}
		public Task<IEnumerable<Categoria>> ListAsync()
		{
			return await _categoriaRepository.ListAsync();
			//throw new System.NotImplementedException();
		}
	}
}
