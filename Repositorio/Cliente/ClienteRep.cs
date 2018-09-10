using Dominio.Contratos;
using System;
using System.Data.OleDb;

namespace Repositorio.Cliente
{
    public class ClienteRep : IClienteRep
    {
        public long Salvar(Dominio.Cliente.Cliente cliente)
        {

            string _comando = null;
            _comando = "insert into tblEvento (";
            _comando = string.Concat(_comando, "nomeEvento, ");
            _comando = string.Concat(_comando, "fotoEvento, ");
            _comando = string.Concat(_comando, "dataEvento, ");
            _comando = string.Concat(_comando, "nomeResponsavel, ");
            _comando = string.Concat(_comando, "cpfResponsavel, ");
            _comando = string.Concat(_comando, "emailResponsavel, ");
            _comando = string.Concat(_comando, "dddCelular, ");
            _comando = string.Concat(_comando, "telefoneCelular, ");
            _comando = string.Concat(_comando, "idSistemaOrigem, ");
            _comando = string.Concat(_comando, "numeroMatricula, ");
            _comando = string.Concat(_comando, "dataCadastro, ");
            _comando = string.Concat(_comando, "dataAlteracao) ");
            _comando = string.Concat(_comando, "select ");
            _comando = string.Concat(_comando, "'", cliente.Evento, "',");
            _comando = string.Concat(_comando, "'", string.Empty, "',");
//            _comando = string.Concat(_comando, "'", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss.fff"), "',");
            _comando = string.Concat(_comando, "", "NULL", ",");
            _comando = string.Concat(_comando, "'", cliente.NomeResponsavel, "', ");
            _comando = string.Concat(_comando, "'", cliente.CPF, "', ");
            _comando = string.Concat(_comando, "'", cliente.Email, "', ");
            _comando = string.Concat(_comando, "", "11", ", ");
            _comando = string.Concat(_comando, "", cliente.Celular, ", ");
            _comando = string.Concat(_comando, "", "2", ", ");
            _comando = string.Concat(_comando, "'", cliente.Matricula, "', ");
//            _comando = string.Concat(_comando, "'", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss.fff"), "',");
            _comando = string.Concat(_comando, "", "NULL", ",");
//            _comando = string.Concat(_comando, "'", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss.fff"), "')");
            _comando = string.Concat(_comando, "", "NULL", ";");

            int retorno = 0;
            try
            {
                //cria a conexão com o banco de dados
                OleDbConnection aConnection = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\AnaPaula\Source\Repos\DreamTeam.PresenteFuturo\Banco\PresenteFuturo.mdb");
                aConnection.Open();

                //cria o objeto command and armazena a consulta SQL
                OleDbCommand aCommand = new OleDbCommand(_comando, aConnection);
                //OleDbCommand aCommand = new OleDbCommand("INSERT INTO tblEvento(nomeEvento) SELECT 'teste' AS Expr1;", aConnection);
                retorno = aCommand.ExecuteNonQuery();
                aConnection.Close();
            }
            catch(Exception ex)
            {
                retorno = 0;
            }

            return retorno;
        }
    }
}
