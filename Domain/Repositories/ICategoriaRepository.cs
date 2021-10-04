using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Organize.API.Domain.Models;

namespace Organize.API.Domain.Repositories
{
	public interface ICategoriaRepository
	{
		Task<IEnumerable<Categoria>> ListAsync();
		Task AddAsync(Categoria categoria);
		Task<Categoria> FindByIdAsync(int id);
		void Update(Categoria categoria);
		void Remove(Categoria categoria);
	}
}
