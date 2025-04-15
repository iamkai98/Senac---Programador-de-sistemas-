using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAtividades.Dominio
{
    internal class Atividade
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public Situacao Situacao { get; set; } // 0 - pendente, 1 - concluída

        public void Criar ()
        {

        }

        public void AtualizarSituacao()
        {


        }

        public Atividade BuscarAtividadeEmAndamento ()
        {
            return new Atividade();
        }

        public List <Atividade> ListarAtividadePendentes()
        {
            return [];
        }

        private bool ValidarTitulo()
        {
            return !string.IsNullOrEmpty(Titulo);
        }

        private Situacao BuscarProximaSituacao()
        {
            return Situacao.Concluído;
        }
    }
}
