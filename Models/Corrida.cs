namespace AppTaxi.Models
{
    public class Corrida
    {
        private int id;
        private int idCliente;
        private int idTaxista;
        private int nota;
        private string descricao;
        private string horario;
        private string motivoPedidoBloqueio;
        private int status;

        public Corrida(int id, int idCliente, int idTaxista, int nota, string descricao, string horario, string motivoPedidoBloqueio, int status)
        {
            this.id = id;
            this.idCliente = idCliente;
            this.idTaxista = idTaxista;
            this.nota = nota;
            this.descricao = descricao;
            this.horario = horario;
            this.motivoPedidoBloqueio = motivoPedidoBloqueio;
            this.status = status;
        }

        public Corrida(int idCliente, int idTaxista)
        {
            this.idCliente = idCliente;
            this.idTaxista = idTaxista;
        }
    }
}