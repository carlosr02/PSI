using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSI.Visao.CadastroProduto
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        DAL.DALProduto DALProduto = new DAL.DALProduto();
        Modelo.Produto Produto;

        protected void Page_Load(object sender, EventArgs e)
        {
            Produto = DALProduto.Select(Convert.ToInt32(Request["codigo"]));
            Label2.Text = Produto.Codigo.ToString();
            Label4.Text = Produto.Descricao;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DALProduto.Delete(Convert.ToInt32(Request["codigo"]));
            Response.Redirect("Index.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }
    }
}