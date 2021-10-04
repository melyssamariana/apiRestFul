using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Organize.API.Domain.Models; 

namespace Organize.API.Domain.Services
{
	public interface ICategoriaService
	{
		Task<IEnumerable<Categoria>> ListAsync();
	}
}
