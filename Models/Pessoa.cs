namespace AppTaxi.Models
{
    public class Pessoa
    {
        public Pessoa(string email, string senha, string cpf, string foto)
        {
            this.email = email;
            this.senha = senha;
            this.cpf = cpf;
            this.foto = foto;
        }
        public Pessoa(int id, string email, string senha, string cpf, string foto)
        {
            this.id = id;
            this.email = email;
            this.senha = senha;
            this.cpf = cpf;
            this.foto = foto;
        }

        public Pessoa(){}
        protected int id;
        protected string email;
        protected string senha;
        protected string cpf;
        protected string localizacao;
        protected string foto;

    }
}