namespace M2S04___exercicios_semanais
{
    public class ContaBancaria1
    {
        private double Numero;
        private Cliente Cliente;
        
        public ContaBancaria1(double Numero, Cliente cliente){
            this.Numero = Numero;
            this.Cliente = cliente;
        }

    public override string ToString()
    {
        return "Conta: " + Numero + ", " + Cliente;
    }

    public void ExibirDados()
    {
        Console.WriteLine("Dados da conta:");
        Console.WriteLine(ToString());
    }
    }
}