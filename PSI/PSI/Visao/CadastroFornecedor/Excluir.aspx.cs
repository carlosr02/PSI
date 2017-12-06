using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSI.Visao.CadastroFornecedor
{
    public partial class Excluir : System.Web.UI.Page
    {
        DAL.DALFornecedor DALFornecedor = new DAL.DALFornecedor();
        Modelo.Fornecedor Fornecedor;

        protected void Page_Load(object sender, EventArgs e)
        {
            Fornecedor = DALFornecedor.Select(Convert.ToInt32(Request["codigo"]));
            Label2.Text = Fornecedor.Codigo.ToString();
            Label4.Text = Fornecedor.Nome;
            Label6.Text = Fornecedor.Telefones;
            Label8.Text = Fornecedor.Cidade;
            Label10.Text = Fornecedor.Estado;
            Label12.Text = Fornecedor.Endereco;
            Label14.Text = Fornecedor.Cpf_cnpj;
            Label16.Text = Fornecedor.Email;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DALFornecedor.Delete(Convert.ToInt32(Request["codigo"]));
            Response.Redirect("Index.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }
    }
}