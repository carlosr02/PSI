using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSI.Visao.CadastroPagamentoSalario
{
    public partial class Alterar : System.Web.UI.Page
    {
        DAL.DALPagamentoSalario DALPagamentoSalario = new DAL.DALPagamentoSalario();
        Modelo.PagamentoSalario PagamentoSalario;

        protected void Page_Load(object sender, EventArgs e)
        {
            PagamentoSalario = DALPagamentoSalario.Select(Convert.ToInt32(Request["codigo"]));
            
            int ano = Convert.ToInt32(DateTime.Now.ToString("yyyy"));
            DropDownList2.Items.Add(ano.ToString());
            DropDownList2.Items.Add((ano - 1).ToString());
            DropDownList2.Items.Add((ano - 2).ToString());
            DropDownList2.Items.Add((ano - 3).ToString());
            DropDownList2.Items.Add((ano - 4).ToString());
            
            if (!IsPostBack)
            {
                TextBox1.Text = PagamentoSalario.Codigo.ToString();
                TextBox2.Text = PagamentoSalario.Funcionario_nome;
                TextBox3.Text = PagamentoSalario.Data.ToShortDateString();
                DropDownList1.SelectedValue = PagamentoSalario.MesReferente.ToString();
                DropDownList2.SelectedValue = PagamentoSalario.AnoReferente.ToString();
                TextBox4.Text = PagamentoSalario.ValorPago.ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            PagamentoSalario.Data = Convert.ToDateTime(TextBox3.Text);
            PagamentoSalario.MesReferente = Convert.ToInt32(DropDownList1.SelectedValue);
            PagamentoSalario.AnoReferente = Convert.ToInt32(DropDownList2.SelectedValue);
            PagamentoSalario.ValorPago = Convert.ToDouble(TextBox4.Text);

            DALPagamentoSalario.Update(PagamentoSalario);
            Response.Redirect(String.Format("Index.aspx?funcionario={0}&mes={1}&ano={2}", PagamentoSalario.Funcionario_codigo, PagamentoSalario.MesReferente, PagamentoSalario.AnoReferente));
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect(String.Format("Index.aspx?funcionario={0}&mes={1}&ano={2}", PagamentoSalario.Funcionario_codigo, PagamentoSalario.MesReferente, PagamentoSalario.AnoReferente));
        }
    }
}