namespace M2S04___exercicios_semanais
{
    public class Cliente
    {
        private string Nome;
        private string cpf;

         public Cliente(string nome, string cpf)
    {
        this.Nome = nome;
        this.cpf = cpf;
    }

    public override string ToString()
    {
        return "Nome: " + Nome + ", CPF: " + cpf;
    }


    }
}