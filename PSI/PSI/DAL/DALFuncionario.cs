using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PSI.DAL
{
    public class DALFuncionario
    {
        private string connectionString = "";

        public DALFuncionario()
        {
            connectionString = ConfigurationManager.ConnectionStrings
                ["PDSI_2017_CarlosConnectionString"].ConnectionString;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Funcionario> SelectAll()
        {
            Modelo.Funcionario aFuncionario;
            List<Modelo.Funcionario> aListFuncionario = new List<Modelo.Funcionario>();

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from Funcionario";

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    aFuncionario = new Modelo.Funcionario(
                        Convert.ToInt32(dr[0]),
                        dr[1] as string,
                        dr[2] as string,
                        dr[3] as string,
                        dr[4] as string,
                        Convert.ToDouble(dr[5]),
                        Convert.ToBoolean(dr[6]),
                        Convert.ToBoolean(dr[7]),
                        dr[8] as string
                        );
                    aListFuncionario.Add(aFuncionario);
                }
            }
            dr.Close();
            conn.Close();
            return aListFuncionario;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public Modelo.Funcionario Select(int codigo)
        {
            Modelo.Funcionario aFuncionario;

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from Funcionario where codigo = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);

            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            aFuncionario = new Modelo.Funcionario(
                        Convert.ToInt32(dr[0]),
                        dr[1] as string,
                        dr[2] as string,
                        dr[3] as string,
                        dr[4] as string,
                        Convert.ToDouble(dr[5]),
                        Convert.ToBoolean(dr[6]),
                        Convert.ToBoolean(dr[7]),
                        dr[8] as string
                        );
            dr.Close();
            conn.Close();

            return aFuncionario;
        }

        [DataObjectMethod(DataObjectMethodType.Delete)]
        public void Delete(int codigo)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("DELETE FROM Funcionario WHERE codigo = @codigo", conn);
            cmd.Parameters.AddWithValue("@codigo", codigo);

            cmd.ExecuteNonQuery();
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public void Insert(Modelo.Funcionario obj)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("INSERT INTO Funcionario (nome, telefones, identidade, clt, salario, motorista, tecnico, observacao) VALUES (@nome, @telefones, @identidade, @clt, @salario, @motorista, @tecnico, @observacao)", conn);
            cmd.Parameters.AddWithValue("@nome", obj.Nome);
            cmd.Parameters.AddWithValue("@telefones", obj.Telefones);
            cmd.Parameters.AddWithValue("@identidade", obj.Identidade);
            cmd.Parameters.AddWithValue("@clt", obj.Clt);
            cmd.Parameters.AddWithValue("@salario", obj.Salario);
            cmd.Parameters.AddWithValue("@motorista", obj.Motorista);
            cmd.Parameters.AddWithValue("@tecnico", obj.Tecnico);
            cmd.Parameters.AddWithValue("@observacao", obj.Observacao);

            cmd.ExecuteNonQuery();
        }

        [DataObjectMethod(DataObjectMethodType.Update)]
        public void Update(Modelo.Funcionario obj)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("UPDATE Funcionario SET nome = @nome, telefones = @telefones, identidade = @identidade, clt = @clt, salario = @salario, motorista = @motorista, tecnico = @tecnico, observacao = @observacao WHERE codigo = @codigo", conn);
            cmd.Parameters.AddWithValue("@codigo", obj.Codigo);
            cmd.Parameters.AddWithValue("@nome", obj.Nome);
            cmd.Parameters.AddWithValue("@telefones", obj.Telefones);
            cmd.Parameters.AddWithValue("@identidade", obj.Identidade);
            cmd.Parameters.AddWithValue("@clt", obj.Clt);
            cmd.Parameters.AddWithValue("@salario", obj.Salario);
            cmd.Parameters.AddWithValue("@motorista", obj.Motorista);
            cmd.Parameters.AddWithValue("@tecnico", obj.Tecnico);
            cmd.Parameters.AddWithValue("@observacao", obj.Observacao);

            cmd.ExecuteNonQuery();
        }
    }
}