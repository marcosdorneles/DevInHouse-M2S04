using System;
namespace M2S04___exercicios_semanais
{
	public class Banco
	{
		private double Saldo;

		public void depositar(double Valor){
			Saldo += Valor;
		}

		public void sacar(double Valor){
			Saldo-=Valor;
		}

		 public override string ToString()
    {
        return "Saldo: " + Saldo;
    }
		public Banco()
		{
		}
	}
}

