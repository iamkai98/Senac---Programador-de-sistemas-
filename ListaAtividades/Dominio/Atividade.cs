using ListaAtividades.Repositorio;
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

        private readonly AtividadeRepositorio repositorio = new(); // instancia repositório criada para ser usadas diversas vezes 

        public bool Criar () // criar uma nova atividade
        {
            if (!ValidarTitulo()) // verificar se o título é válido
            {
                return false;
            }

            
            repositorio.Criar(Titulo); // inserir no banco de dados

            return true;
            
        }

        public bool AtualizarSituacao()
        {
            if (!ValidarId()) // verificar se o id é válido (id maior que 0)
            {
                return false;
            }
           

            if (!ValidarSituacao()) // verificar se a situação é válida (situacao diferente de concluído)
            {
                return false;
            }

            Atividade atividadeEmAndamento = BuscarAtividadeEmAndamento(); // buscar a atividade em andamento (situacao = 1)
            Situacao novaSituacao = BuscarProximaSituacao(); //buscar a proxima situação (situacao = 2)



            if (atividadeEmAndamento.Id > 0 && atividadeEmAndamento.Situacao == BuscarProximaSituacao())
            {
                return false; // verificar se a atividade em andamento é diferente de 0 e se a situação é igual a 1
            }

            

            repositorio.AtualizarSituacao(Id, (int) novaSituacao); // atualizar a situação no banco de dados
            return true;
        }

        public Atividade BuscarAtividadeEmAndamento ()
        {
            return repositorio.BuscarAtividadeEmAndamento(); // buscar a atividade em andamento no banco de dados
        }

        public List <Atividade> ListarAtividadePendentes()
        {
            return repositorio.ListarAtividadePendente(); // listar as atividades pendentes no banco de dados
        }

        private bool ValidarId()
        {
            return Id > 0;
        }

        private bool ValidarTitulo()
        {
            return !string.IsNullOrEmpty(Titulo);
        }

        private bool ValidarSituacao() 
        { 
            return Situacao != Situacao.Concluído; // verificar se a situação é diferente de concluído
        }
        private Situacao BuscarProximaSituacao()
        {
            if (Situacao == Situacao.Pendente)
            {
                return Situacao.Realizando;
            }
            return Situacao.Concluído;
        }
    }
}
