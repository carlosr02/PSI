using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSI.Visao.CadastroPagamentoSalario
{
    public partial class Excluir : System.Web.UI.Page
    {
        DAL.DALPagamentoSalario DALPagamentoSalario = new DAL.DALPagamentoSalario();
        Modelo.PagamentoSalario PagamentoSalario;

        protected void Page_Load(object sender, EventArgs e)
        {
            PagamentoSalario = DALPagamentoSalario.Select(Convert.ToInt32(Request["codigo"]));
            Label2.Text = PagamentoSalario.Codigo.ToString();
            Label4.Text = PagamentoSalario.Funcionario_nome;
            Label6.Text = PagamentoSalario.Data.ToShortDateString();
            Label8.Text = PagamentoSalario.MesReferente.ToString();
            Label9.Text = PagamentoSalario.AnoReferente.ToString();
            Label11.Text = PagamentoSalario.ValorPago.ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DALPagamentoSalario.Delete(Convert.ToInt32(Request["codigo"]));
            Response.Redirect(String.Format("Index.aspx?funcionario={0}&mes={1}&ano={2}", PagamentoSalario.Funcionario_codigo, PagamentoSalario.MesReferente, PagamentoSalario.AnoReferente));
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect(String.Format("Index.aspx?funcionario={0}&mes={1}&ano={2}", PagamentoSalario.Funcionario_codigo, PagamentoSalario.MesReferente, PagamentoSalario.AnoReferente));
        }
    }
}