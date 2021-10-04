using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Organize.API.Domain.Models
{
	public enum EUnidadeMedida
	{
		[Description("UN")]
		EUnidadeMedida = 1,
		[Description("MG")]
		Miligrama = 2,
		[Description("G")]
		Grama = 3,
		[Description("KG")]
		Kilograma = 4,
		[Description("L")]
		Litro = 5
	}
}
