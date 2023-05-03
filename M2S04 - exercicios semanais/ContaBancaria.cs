using System;
namespace M2S04___exercicios_semanais
{
	public class ContaBancaria
	{
		private double Numeroconta;
		private double Saldo;

		public ContaBancaria(double NumeroConta)
		{
			this.Numeroconta = NumeroConta;
			this.Saldo = 0;
		}

		public void deposita(double valor)
		{
			Saldo += valor;
		}

		public void saca(double valor)
		{
			Saldo -= valor;
		}

		public double getSaldo()
		{
			return Saldo;
           
        }
	}
}

