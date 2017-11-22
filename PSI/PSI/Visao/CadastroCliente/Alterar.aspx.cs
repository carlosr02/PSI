using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSI.Visao.CadastroCliente
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        DAL.DALCliente DALCliente = new DAL.DALCliente();
        Modelo.Cliente Cliente;

        protected void Page_Load(object sender, EventArgs e)
        {
            Cliente = DALCliente.Select(Convert.ToInt32(Request["codigo"]));
            if (!IsPostBack)
            {
                TextBox1.Text = Cliente.Codigo.ToString();
                TextBox2.Text = Cliente.Nome;
                TextBox3.Text = Cliente.Telefones;
                TextBox4.Text = Cliente.Cidade;
                TextBox5.Text = Cliente.Estado;
                TextBox6.Text = Cliente.Endereco;
                TextBox7.Text = Cliente.Cpf_cnpj;
                TextBox8.Text = Cliente.Email;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Cliente.Nome = TextBox2.Text;
            Cliente.Telefones = TextBox3.Text;
            Cliente.Cidade = TextBox4.Text;
            Cliente.Estado = TextBox5.Text;
            Cliente.Endereco = TextBox6.Text;
            Cliente.Cpf_cnpj = TextBox7.Text;
            Cliente.Email = TextBox8.Text;

            DALCliente.Update(Cliente);
            Response.Redirect("Index.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }
    }
}