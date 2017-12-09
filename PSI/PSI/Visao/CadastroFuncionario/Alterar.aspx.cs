using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSI.Visao.CadastroFuncionario
{
    public partial class Alterar : System.Web.UI.Page
    {
        DAL.DALFuncionario DALFuncionario = new DAL.DALFuncionario();
        Modelo.Funcionario Funcionario;

        protected void Page_Load(object sender, EventArgs e)
        {
            Funcionario = DALFuncionario.Select(Convert.ToInt32(Request["codigo"]));
            if (!IsPostBack)
            {
                TextBox1.Text = Funcionario.Codigo.ToString();
                TextBox2.Text = Funcionario.Nome;
                TextBox3.Text = Funcionario.Telefones;
                TextBox4.Text = Funcionario.Identidade;
                TextBox5.Text = Funcionario.Clt;
                TextBox6.Text = Funcionario.Salario;
                CheckBox1.Checked = Funcionario.Motorista;
                CheckBox2.Checked = Funcionario.Tecnico;
                TextBox7.Text = Funcionario.Observacao;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Funcionario.Nome = TextBox2.Text;
            Funcionario.Telefones = TextBox3.Text;
            Funcionario.Identidade = TextBox4.Text;
            Funcionario.Clt = TextBox5.Text;
            Funcionario.Salario = TextBox6.Text;
            Funcionario.Motorista = CheckBox1.Checked;
            Funcionario.Tecnico = CheckBox2.Checked;
            Funcionario.Observacao = TextBox7.Text;

            DALFuncionario.Update(Funcionario);
            Response.Redirect("Index.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }
    }
}