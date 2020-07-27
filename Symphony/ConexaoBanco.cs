using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Npgsql;

namespace Symphony
{
    public static class ConexaoBanco
    {
        
        //Variavel que contem os dados da conexão ao banco
        //postgres utilizando o npgsql que é um drive nativo
        //para acesso ao postgres para o C#
        /*static string stringConexao =
            "Server = 200.145.153.175;" +
            "Port = 5432;" +
            "Database = 1_72A_AULAS_2018;" +
            "User ID = alunocti;" +
            "password = alunocti;";*/

        static string stringConexao = "Server = 127.0.0.1;"
                + "Port = 5432;"
                + "Database = Symphony;"
                + "User ID = postgres;"
                + "Password = sqladmin;";

        static NpgsqlConnection cn = new NpgsqlConnection();

        public static void Conectar()
        {
            try
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.ConnectionString = stringConexao;
                    cn.Open();
                }
            }
            catch (NpgsqlException ex)
            {
                throw new NpgsqlException(ex.Message);
            }
        }

        public static void Conectar(string server, string port, string database, string user, string password)
        {
            try
            {
                stringConexao =
                    "Server = " + server +
                    ";Port = " + port +
                    ";Database = " + database +
                    ";User ID = " + user +
                    ";password = " + password + ";";

                if (cn.State != ConnectionState.Open)
                {
                    cn.ConnectionString = stringConexao;
                    cn.Open();
                }
            }
            catch (NpgsqlException ex)
            {
                throw new NpgsqlException(ex.Message);
            }
        }

        public static void Desconectar()
        {
            cn.Close();
            //cn.Dispose();
        }

        //Executa uma query no banco de dados. (Sem retorno)
        public static void Executar(string sql)
        {
            try
            {
                Conectar();

                NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                cmd.ExecuteNonQuery();

                Desconectar();
            }
            catch (NpgsqlException ex)
            {
                Desconectar();
                throw new NpgsqlException(ex.Message);
            }
        }

        //Executa uma query no banco de dados com parametros
        public static void Executar(string sql, List<object> parametros)
        {
            try
            {
                Conectar();

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.CommandText = sql;
                cmd.Connection = cn;
                int i = 1;

                foreach (object parametro in parametros)
                {
                    cmd.Parameters.AddWithValue("@" + i++.ToString(), parametro);
                }

                cmd.ExecuteNonQuery();

                Desconectar();
            }
            catch (NpgsqlException ex)
            {
                Desconectar();
                throw new NpgsqlException(ex.Message);
            }
        }

        //Executa uma query no banco de dados com parametros retornando 'campoRetorno'
        public static Int64 Executar(string sql, List<object> parametros, string campoRetorno)
        {
            try
            {
                Conectar();

                NpgsqlCommand cmd = new NpgsqlCommand();
                Int64 modificado = 0;
                cmd.CommandText = sql + " RETURNING " + campoRetorno;
                cmd.Connection = cn;
                int i = 1;

                foreach (object parametro in parametros)
                {
                    cmd.Parameters.AddWithValue("@" + i++.ToString(), parametro);
                }

                modificado = Convert.ToInt64(cmd.ExecuteScalar());

                Desconectar();

                return modificado;
            }
            catch (NpgsqlException ex)
            {
                Desconectar();
                throw new NpgsqlException(ex.Message);
            }
        }

        //Select simples retornando um DataReader
        public static NpgsqlDataReader Selecionar(string sql)
        {
            try
            {
                Conectar();

                NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);


                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (NpgsqlException ex)
            {
                Desconectar();
                throw new NpgsqlException(ex.Message);
            }
        }

        //Select com parametros retornando um DataReader
        public static NpgsqlDataReader Selecionar(string sql, List<object> parametros)
        {
            try
            {
                Conectar();

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.CommandText = sql;
                cmd.Connection = cn;
                int i = 1;
                foreach (object parametro in parametros)
                {
                    cmd.Parameters.AddWithValue("@" + i++.ToString(), parametro);
                }

                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (NpgsqlException ex)
            {
                Desconectar();
                throw new NpgsqlException(ex.Message);
            }

        }

        // Select retornando os dados em um DataTable
        public static DataTable SelecionarDataTable(string sql)
        {
            try
            {
                Conectar();
                // Cria o objeto DataTable
                DataTable dt = new DataTable();
                NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                da.Fill(dt);
                Desconectar();
                return dt;
            }
            catch (NpgsqlException ex)
            {
                Desconectar();
                throw new ApplicationException(ex.Message);
            }
        }

        public static DataSet SelecionarDataSet(string sql)
        {
            try
            {
                Conectar();
                // Cria o objeto DataSet
                DataSet ds = new DataSet();
                NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                da.Fill(ds);
                Desconectar();
                return ds;
            }
            catch (NpgsqlException ex)
            {
                Desconectar();
                throw new ApplicationException(ex.Message);
            }
        }

        public static DataSet SelecionarDataSet(string tabela, string campos, string where = "", string orderBy = "")
        {
            try
            {
                Conectar();
                // Cria o objeto DataSet
                DataSet ds = new DataSet();
                string sql = @"select " + campos + " from " + tabela;
                if (where != "")
                    sql += @" where " + where + " ";
                if (orderBy != "")
                    sql += @" order by " + orderBy + " ";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                da.Fill(ds, tabela);
                Desconectar();
                return ds;
            }
            catch (NpgsqlException ex)
            {
                Desconectar();
                throw new ApplicationException(ex.Message);
            }
        }
    }
    
}
