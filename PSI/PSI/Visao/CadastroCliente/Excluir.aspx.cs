using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSI.Visao.CadastroCliente
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        DAL.DALCliente DALCliente = new DAL.DALCliente();
        Modelo.Cliente Cliente;

        protected void Page_Load(object sender, EventArgs e)
        {
            Cliente = DALCliente.Select(Convert.ToInt32(Request["codigo"]));
            Label2.Text = Cliente.Codigo.ToString();
            Label4.Text = Cliente.Nome;
            Label6.Text = Cliente.Telefones;
            Label8.Text = Cliente.Cidade;
            Label10.Text = Cliente.Estado;
            Label12.Text = Cliente.Endereco;
            Label14.Text = Cliente.Cpf_cnpj;
            Label16.Text = Cliente.Email;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DALCliente.Delete(Convert.ToInt32(Request["codigo"]));
            Response.Redirect("Index.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }
    }
}