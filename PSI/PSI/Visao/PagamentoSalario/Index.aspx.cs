using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSI.Visao.CadastroPagamentoSalario
{
    public partial class Index : System.Web.UI.Page
    {
        DAL.DALFuncionario DALFuncionario = new DAL.DALFuncionario();
        Modelo.Funcionario Funcionario;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Modelo.Funcionario> Funcionarios = DALFuncionario.SelectAll();
                foreach (Modelo.Funcionario f in Funcionarios)
                {
                    ListItem item = new ListItem(f.Nome, f.Codigo.ToString());
                    DropDownList1.Items.Add(item);
                }

                int ano = Convert.ToInt32(DateTime.Now.ToString("yyyy"));
                DropDownList3.Items.Add(ano.ToString());
                DropDownList3.Items.Add((ano - 1).ToString());
                DropDownList3.Items.Add((ano - 2).ToString());
                DropDownList3.Items.Add((ano - 3).ToString());
                DropDownList3.Items.Add((ano - 4).ToString());

                if (Request.QueryString.HasKeys())
                {
                    DropDownList1.SelectedValue = Request.QueryString["funcionario"];
                    DropDownList2.SelectedValue = Request.QueryString["mes"];
                    DropDownList3.SelectedValue = Request.QueryString["ano"];
                }

                else DropDownList2.SelectedValue = DateTime.Now.ToString("MM");

                Button2_Click(new object(), new EventArgs());
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect(String.Format("Incluir.aspx?funcionario={0}&mes={1}&ano={2}", DropDownList1.SelectedValue, DropDownList2.SelectedValue, DropDownList3.SelectedValue));
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Funcionario = DALFuncionario.Select(Convert.ToInt32(DropDownList1.SelectedValue));
            Label1.Text = Funcionario.Salario;

            double total_pago = 0;
            foreach (GridViewRow row in GridView1.Rows)
            {
                total_pago += Convert.ToDouble(row.Cells[4].Text);
            }
            Label2.Text = total_pago.ToString();

            double debito = Convert.ToDouble(Funcionario.Salario) - total_pago;
            Label3.Text = debito.ToString();
        }

        protected void GridView1_DataBound(object sender, EventArgs e)
        {
            Button2_Click(new object(), new EventArgs());
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Alterar")
            {
                int index = Convert.ToInt32(e.CommandArgument);

                int codigo = Convert.ToInt32(GridView1.DataKeys[index].Value.ToString());

                Response.Redirect("Alterar.aspx?codigo=" + codigo);
            }

            if (e.CommandName == "Excluir")
            {
                int index = Convert.ToInt32(e.CommandArgument);

                int codigo = Convert.ToInt32(GridView1.DataKeys[index].Value.ToString());

                Response.Redirect("Excluir.aspx?codigo=" + codigo);
            }
        }
    }
}