using Loja.Infra;
using NHibernate;
using System;
namespace Loja
{
	class Program
	{
		static void Main(string[] args)
		{
			NHibernateHelper.GeraSchema();

			Console.Read();
		}
	}
}
