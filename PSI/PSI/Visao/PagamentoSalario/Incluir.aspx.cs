using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSI.Visao.CadastroPagamentoSalario
{
    public partial class Incluir : System.Web.UI.Page
    {
        DAL.DALPagamentoSalario DALPagamentoSalario = new DAL.DALPagamentoSalario();
        Modelo.PagamentoSalario PagamentoSalario;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DAL.DALFuncionario DALFuncionario = new DAL.DALFuncionario();
                List<Modelo.Funcionario> Funcionarios = DALFuncionario.SelectAll();
                foreach (Modelo.Funcionario f in Funcionarios)
                {
                    ListItem item = new ListItem(f.Nome, f.Codigo.ToString());
                    DropDownList1.Items.Add(item);
                }
                DropDownList1.SelectedValue = Request.QueryString["funcionario"];

                TextBox1.Text = DateTime.Now.ToString("dd/MM/yyyy");

                DropDownList2.SelectedValue = Request.QueryString["mes"];

                int ano = Convert.ToInt32(DateTime.Now.ToString("yyyy"));
                DropDownList3.Items.Add(ano.ToString());
                DropDownList3.Items.Add((ano - 1).ToString());
                DropDownList3.Items.Add((ano - 2).ToString());
                DropDownList3.Items.Add((ano - 3).ToString());
                DropDownList3.Items.Add((ano - 4).ToString());
                DropDownList3.SelectedValue = Request.QueryString["ano"];
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DateTime data = Convert.ToDateTime(TextBox1.Text);
            int mesReferente = Convert.ToInt32(DropDownList2.SelectedValue);
            int anoReferente = Convert.ToInt32(DropDownList3.SelectedValue);
            double valorPago = Convert.ToDouble(TextBox4.Text);
            int funcionario_codigo = Convert.ToInt32(DropDownList1.SelectedValue);

            PagamentoSalario = new Modelo.PagamentoSalario(0, data, mesReferente, anoReferente, valorPago, funcionario_codigo);

            DALPagamentoSalario.Insert(PagamentoSalario);

            Response.Redirect(String.Format("Index.aspx?funcionario={0}&mes={1}&ano={2}", PagamentoSalario.Funcionario_codigo, PagamentoSalario.MesReferente, PagamentoSalario.AnoReferente));
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect(String.Format("Index.aspx?funcionario={0}&mes={1}&ano={2}", Request.QueryString["funcionario"], Request.QueryString["mes"], Request.QueryString["ano"]));
        }
    }
}