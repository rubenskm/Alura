using System;

namespace Caelum.CaixaEletronico.Sistema
{
	static class StringUtils
	{
		public static string Pluralize(this string palavra)
		{
			if (palavra.EndsWith("s"))
			{
				return palavra;
			}
			else
			{
				return String.Format("{0}s", palavra);
			}
		}
	}
}
