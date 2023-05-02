using System;
namespace M2S04___exercicios_semanais
{
	public class Pessoa
	{
		public Pessoa(String Nome, int Idade, String Endereco)
		{
			this.Nome = Nome;
			this.Idade = Idade;
			this.Endereco = Endereco;
		}

        public Pessoa()
        {
        }

        private string Nome { get; set; }
		protected int Idade { get; set; }
        public string Endereco { get; set; }

        public void saudacao()
		{
			Console.WriteLine($"Olá, meu nome é {Nome} e eu tenho {Idade} anos");
		}
	}
}

