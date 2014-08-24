namespace Caelum.CaixaEletronico
{
	public class GerenciadorDeImposto
	{
		public double Total { get; private set; }
		public void Adiciona(ITributavel tributavel)
		{
			Total += tributavel.CalculaTributos();
		}
	}
}