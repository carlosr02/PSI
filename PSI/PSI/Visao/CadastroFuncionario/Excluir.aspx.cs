using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSI.Visao.CadastroFuncionario
{
    public partial class Excluir : System.Web.UI.Page
    {
        DAL.DALFuncionario DALFuncionario = new DAL.DALFuncionario();
        Modelo.Funcionario Funcionario;

        protected void Page_Load(object sender, EventArgs e)
        {
            Funcionario = DALFuncionario.Select(Convert.ToInt32(Request["codigo"]));
            Label2.Text = Funcionario.Codigo.ToString();
            Label4.Text = Funcionario.Nome;
            Label6.Text = Funcionario.Telefones;
            Label8.Text = Funcionario.Identidade;
            Label10.Text = Funcionario.Clt;
            Label12.Text = Funcionario.Salario;
            if (Funcionario.Motorista == true) Label14.Text = "Sim";
            else Label14.Text = "Não";
            if (Funcionario.Tecnico == true) Label16.Text = "Sim";
            else Label16.Text = "Não";
            Label18.Text = Funcionario.Observacao;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DAL.DALPagamentoSalario DALPagamentoSalario = new DAL.DALPagamentoSalario();

            foreach(Modelo.PagamentoSalario Pagamento 
                in DALPagamentoSalario.SelectByFuncionario(Convert.ToInt32(Request["codigo"])))
            {
                DALPagamentoSalario.Delete(Pagamento.Codigo);
            }

            DALFuncionario.Delete(Convert.ToInt32(Request["codigo"]));
            Response.Redirect("Index.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }
    }
}