using ListaAtividades.banco_de_dados;
using ListaAtividades.Dominio;
using MySql.Data.MySqlClient;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAtividades.Repositorio
{
     internal class AtividadeRepositorio
    {
        public void Criar(string titulo)
        {

            using (var con = Database.GetConnection()) // criar uma nova conexão com o banco de dados
            {
                con.Open(); // abrir a conexão com o banco de dados

                string query = "INSERT INTO atividade (titulo) VALUES (@titulo);"; // comando SQL para inserir um novo registro na tabela atividade
                using ( var cmd = new MySqlCommand(query, con)) // criar um novo comando SQL
                {
                    cmd.Parameters.AddWithValue("@titulo", titulo); // substituir o valor do parâmetro  @titulo
                    cmd.ExecuteNonQuery(); // executar o comando 
                }
            }
        }

        public void AtualizarSituacao(int id, int NovaSituacao)
        {
            using (var con = Database.GetConnection()) // criar uma nova conexão com o banco de dados
            {
                con.Open(); // abrir a conexão com o banco de dados

                string query = "UPDATE atividade SET situacao = @situacao WHERE id = @id;";
                using (var cmd = new MySqlCommand(query, con)) // criar um novo comando SQL
                {
                    cmd.Parameters.AddWithValue("@situacao", NovaSituacao); // substituir o valor do parâmetro @situacao
                    cmd.Parameters.AddWithValue("@id", id); // substituir o valor do parâmetro @id
                    cmd.ExecuteNonQuery(); // executar o comando
                }



            }

        }   

        public Atividade BuscarAtividadeEmAndamento()
        {
            using (var con = Database.GetConnection())
            {
                con.Open();
                string query = $"SELECT * FROM atividade WHERE situacao = {Situacao.Realizando};"; // Select * from atividade where situacao = 1

                using (var cmd = new MySqlCommand (query, con))

                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read()) // se houver um registro 
                        {
                            return new Atividade()
                            {
                                Id = reader.GetInt32("id"), // converter o id para string
                                Titulo = reader.GetString("titulo"), // pegar o titulo
                                Situacao = (Situacao)reader.GetInt32("situacao") // pegar a situacao
                            };
                        }
                    }
                }

            }

            return new Atividade();
        }

        public List<Atividade> ListarAtividadePendente() // Criacao de uma lista de atividades pendentes
        {
            List<Atividade> atividades = []; // criar uma lista de atividades

            using (var con = Database.GetConnection())
            {

                con.Open(); // abrir a conexão com o banco de dados
                string query = $"SELECT * FROM atividade WHERE situacao = {Situacao.Pendente};"; // Select * from atividade where situacao = 0

                using (var cmd = new MySqlCommand(query, con)) // criar um novo comando SQL
                {
                    using (var reader = cmd.ExecuteReader()) // executar o comando 
                    {
                        while (reader.Read()) // se houver um ou mais registros
                            atividades.Add(new Atividade()
                            {
                                Id = reader.GetInt32("id"),// converter o id para string
                                Titulo = reader.GetString("título"),// pegar o titulo
                                Situacao = (Situacao)reader.GetInt32("Situacao") // pegar a situacao
                            });
                    }
                }

                     
            }

            return atividades;
        }
    }

    
}
