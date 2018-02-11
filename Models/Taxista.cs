namespace AppTaxi.Models
{
    public class Taxista : Pessoa
    {
        public Taxista(string email, string senha, string cpf, string foto, int numeroCarro)
        {
            this.email = email;
            this.senha = senha;
            this.cpf = cpf;
            this.foto = foto;
            this.numeroCarro = numeroCarro;
        }

        public Taxista(int id, string email, string cpf, string foto, int numeroCarro, int status)
        {
            this.id = id;
            this.email = email;
            this.cpf = cpf;
            this.foto = foto;
            this.numeroCarro = numeroCarro;
            this.status = status;
        }

        private int numeroCarro;
        private int status;
    }
}