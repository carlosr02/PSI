using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSI.Visao.CadastroFornecedor
{
    public partial class Incluir : System.Web.UI.Page
    {
        DAL.DALFornecedor DALFornecedor = new DAL.DALFornecedor();
        Modelo.Fornecedor Fornecedor;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string nome = TextBox1.Text;
            string telefones = TextBox2.Text;
            string cidade = TextBox3.Text;
            string estado = TextBox4.Text;
            string endereco = TextBox5.Text;
            string cpf_cnpj = TextBox6.Text;
            string email = TextBox7.Text;

            Fornecedor = new Modelo.Fornecedor(0, nome, telefones, cidade, estado, endereco, cpf_cnpj, email);

            DALFornecedor.Insert(Fornecedor);

            Response.Redirect("Index.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }
    }
}