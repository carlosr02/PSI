using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSI.Visao.CadastroFornecedor
{
    public partial class Alterar : System.Web.UI.Page
    {
        DAL.DALFornecedor DALFornecedor = new DAL.DALFornecedor();
        Modelo.Fornecedor Fornecedor;

        protected void Page_Load(object sender, EventArgs e)
        {
            Fornecedor = DALFornecedor.Select(Convert.ToInt32(Request["codigo"]));
            if (!IsPostBack)
            {
                TextBox1.Text = Fornecedor.Codigo.ToString();
                TextBox2.Text = Fornecedor.Nome;
                TextBox3.Text = Fornecedor.Telefones;
                TextBox4.Text = Fornecedor.Cidade;
                TextBox5.Text = Fornecedor.Estado;
                TextBox6.Text = Fornecedor.Endereco;
                TextBox7.Text = Fornecedor.Cpf_cnpj;
                TextBox8.Text = Fornecedor.Email;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Fornecedor.Nome = TextBox2.Text;
            Fornecedor.Telefones = TextBox3.Text;
            Fornecedor.Cidade = TextBox4.Text;
            Fornecedor.Estado = TextBox5.Text;
            Fornecedor.Endereco = TextBox6.Text;
            Fornecedor.Cpf_cnpj = TextBox7.Text;
            Fornecedor.Email = TextBox8.Text;

            DALFornecedor.Update(Fornecedor);
            Response.Redirect("Index.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }
    }
}