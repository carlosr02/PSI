using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PSI.DAL
{
    public class DALCliente
    {
        private string connectionString = "";

        public DALCliente()
        {
            connectionString = ConfigurationManager.ConnectionStrings
                ["PDSI_2017_CarlosConnectionString"].ConnectionString;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Cliente> SelectAll()
        {
            Modelo.Cliente aCliente;
            List<Modelo.Cliente> aListCliente = new List<Modelo.Cliente>();

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from Cliente";

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    aCliente = new Modelo.Cliente(
                        Convert.ToInt32(dr[0]),
                        dr[1] as string,
                        dr[2] as string,
                        dr[3] as string,
                        dr[4] as string,
                        dr[5] as string,
                        dr[6] as string,
                        dr[7] as string
                        );
                    aListCliente.Add(aCliente);
                }
            }
            dr.Close();
            conn.Close();
            return aListCliente;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public Modelo.Cliente Select(int codigo)
        {
            Modelo.Cliente aCliente;

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from Cliente where codigo = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);

            SqlDataReader dr = cmd.ExecuteReader();

            dr.Read();
            aCliente = new Modelo.Cliente(
                Convert.ToInt32(dr[0]),
                dr[1] as string,
                dr[2] as string,
                dr[3] as string,
                dr[4] as string,
                dr[5] as string,
                dr[6] as string,
                dr[7] as string
                );

            dr.Close();
            conn.Close();

            return aCliente;
        }

        [DataObjectMethod(DataObjectMethodType.Delete)]
        public void Delete(int codigo)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("DELETE FROM Cliente WHERE codigo = @codigo", conn);
            cmd.Parameters.AddWithValue("@codigo", codigo);

            cmd.ExecuteNonQuery();
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public void Insert(Modelo.Cliente obj)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("INSERT INTO Cliente (nome, telefones, cidade, estado, endereco, cpf_cnpj, email) VALUES (@nome, @telefones, @cidade, @estado, @endereco, @cpf_cnpj, @email)", conn);
            cmd.Parameters.AddWithValue("@nome", obj.Nome);
            cmd.Parameters.AddWithValue("@telefones", obj.Telefones);
            cmd.Parameters.AddWithValue("@cidade", obj.Cidade);
            cmd.Parameters.AddWithValue("@estado", obj.Estado);
            cmd.Parameters.AddWithValue("@endereco", obj.Endereco);
            cmd.Parameters.AddWithValue("@cpf_cnpj", obj.Cpf_cnpj);
            cmd.Parameters.AddWithValue("@email", obj.Email);

            cmd.ExecuteNonQuery();
        }

        [DataObjectMethod(DataObjectMethodType.Update)]
        public void Update(Modelo.Cliente obj)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("UPDATE Cliente SET nome = @nome, telefones = @telefones, cidade = @cidade, estado = @estado, endereco = @endereco, cpf_cnpj = @cpf_cnpj, email = @email WHERE codigo = @codigo", conn);
            cmd.Parameters.AddWithValue("@codigo", obj.Codigo);
            cmd.Parameters.AddWithValue("@nome", obj.Nome);
            cmd.Parameters.AddWithValue("@telefones", obj.Telefones);
            cmd.Parameters.AddWithValue("@cidade", obj.Cidade);
            cmd.Parameters.AddWithValue("@estado", obj.Estado);
            cmd.Parameters.AddWithValue("@endereco", obj.Endereco);
            cmd.Parameters.AddWithValue("@cpf_cnpj", obj.Cpf_cnpj);
            cmd.Parameters.AddWithValue("@email", obj.Email);

            cmd.ExecuteNonQuery();
        }
    }
}