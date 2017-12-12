using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PSI.DAL
{
    public class DALPagamentoSalario
    {
        private string connectionString = "";

        public DALPagamentoSalario()
        {
            connectionString = ConfigurationManager.ConnectionStrings
                ["PDSI_2017_CarlosConnectionString"].ConnectionString;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.PagamentoSalario> SelectByFuncionario(int funcionario_codigo)
        {
            Modelo.PagamentoSalario aPagamentoSalario;
            List<Modelo.PagamentoSalario> aListPagamentoSalario = new List<Modelo.PagamentoSalario>();

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select pg.codigo,pg.data,pg.mesReferente,pg.anoReferente,pg.valorPago,pg.funcionario_codigo,f.nome from PagamentoSalario pg inner join Funcionario f on f.codigo = pg.funcionario_codigo where pg.funcionario_codigo = @funcionario_codigo order by pg.data";
            cmd.Parameters.Add("@funcionario_codigo", funcionario_codigo);

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    aPagamentoSalario = new Modelo.PagamentoSalario(
                        Convert.ToInt32(dr[0]),
                        Convert.ToDateTime(dr[1]),
                        Convert.ToInt32(dr[2]),
                        Convert.ToInt32(dr[3]),
                        Convert.ToDouble(dr[4]),
                        Convert.ToInt32(dr[5]),
                        dr[6] as string
                        );
                    aListPagamentoSalario.Add(aPagamentoSalario);
                }
            }
            dr.Close();
            conn.Close();
            return aListPagamentoSalario;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.PagamentoSalario> SelectByFuncionarioEMesEAno(int funcionario_codigo, int mesReferente, int anoReferente)
        {
            Modelo.PagamentoSalario aPagamentoSalario;
            List<Modelo.PagamentoSalario> aListPagamentoSalario = new List<Modelo.PagamentoSalario>();

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select pg.codigo,pg.data,pg.mesReferente,pg.anoReferente,pg.valorPago,pg.funcionario_codigo,f.nome from PagamentoSalario pg inner join Funcionario f on f.codigo = pg.funcionario_codigo where pg.funcionario_codigo = @funcionario_codigo and pg.mesReferente = @mesReferente and pg.anoReferente = @anoReferente order by pg.data";
            cmd.Parameters.Add("@funcionario_codigo", funcionario_codigo);
            cmd.Parameters.Add("@mesReferente", mesReferente);
            cmd.Parameters.Add("@anoReferente", anoReferente);

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    aPagamentoSalario = new Modelo.PagamentoSalario(
                        Convert.ToInt32(dr[0]),
                        Convert.ToDateTime(dr[1]),
                        Convert.ToInt32(dr[2]),
                        Convert.ToInt32(dr[3]),
                        Convert.ToDouble(dr[4]),
                        Convert.ToInt32(dr[5]),
                        dr[6] as string
                        );
                    aListPagamentoSalario.Add(aPagamentoSalario);
                }
            }
            dr.Close();
            conn.Close();
            return aListPagamentoSalario;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public Modelo.PagamentoSalario Select(int codigo)
        {
            Modelo.PagamentoSalario aPagamentoSalario;

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select pg.codigo,pg.data,pg.mesReferente,pg.anoReferente,pg.valorPago,pg.funcionario_codigo,f.nome from PagamentoSalario pg inner join Funcionario f on f.codigo = pg.funcionario_codigo where pg.codigo = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);

            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            aPagamentoSalario = new Modelo.PagamentoSalario(
                        Convert.ToInt32(dr[0]),
                        Convert.ToDateTime(dr[1]),
                        Convert.ToInt32(dr[2]),
                        Convert.ToInt32(dr[3]),
                        Convert.ToDouble(dr[4]),
                        Convert.ToInt32(dr[5]),
                        dr[6] as string
                        );
            dr.Close();
            conn.Close();

            return aPagamentoSalario;
        }

        [DataObjectMethod(DataObjectMethodType.Delete)]
        public void Delete(int codigo)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("DELETE FROM PagamentoSalario WHERE codigo = @codigo", conn);
            cmd.Parameters.AddWithValue("@codigo", codigo);

            cmd.ExecuteNonQuery();
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public void Insert(Modelo.PagamentoSalario obj)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("INSERT INTO PagamentoSalario (data, mesReferente, anoReferente, valorPago, funcionario_codigo) VALUES (@data, @mesReferente, @anoReferente, @valorPago, @funcionario_codigo)", conn);
            cmd.Parameters.AddWithValue("@data", obj.Data);
            cmd.Parameters.AddWithValue("@mesReferente", obj.MesReferente);
            cmd.Parameters.AddWithValue("@anoReferente", obj.AnoReferente);
            cmd.Parameters.AddWithValue("@valorPago", obj.ValorPago);
            cmd.Parameters.AddWithValue("@funcionario_codigo", obj.Funcionario_codigo);

            cmd.ExecuteNonQuery();
        }

        [DataObjectMethod(DataObjectMethodType.Update)]
        public void Update(Modelo.PagamentoSalario obj)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("UPDATE PagamentoSalario SET data = @data, mesReferente = @mesReferente, anoReferente = @anoReferente, valorPago = @valorPago WHERE codigo = @codigo", conn);
            cmd.Parameters.AddWithValue("@codigo", obj.Codigo);
            cmd.Parameters.AddWithValue("@data", obj.Data);
            cmd.Parameters.AddWithValue("@mesReferente", obj.MesReferente);
            cmd.Parameters.AddWithValue("@anoReferente", obj.AnoReferente);
            cmd.Parameters.AddWithValue("@valorPago", obj.ValorPago);

            cmd.ExecuteNonQuery();
        }
    }
}