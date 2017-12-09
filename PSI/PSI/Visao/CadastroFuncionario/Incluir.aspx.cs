using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSI.Visao.CadastroFuncionario
{
    public partial class Incluir : System.Web.UI.Page
    {
        DAL.DALFuncionario DALFuncionario = new DAL.DALFuncionario();
        Modelo.Funcionario Funcionario;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string nome = TextBox1.Text;
            string telefones = TextBox2.Text;
            string identidade = TextBox3.Text;
            string clt = TextBox4.Text;
            string salario = TextBox5.Text;
            bool motorista = CheckBox1.Checked;
            bool tecnico = CheckBox2.Checked;
            string observacao = TextBox6.Text;

            Funcionario = new Modelo.Funcionario(0, nome, telefones, identidade, clt, salario, motorista, tecnico, observacao);

            DALFuncionario.Insert(Funcionario);

            Response.Redirect("Index.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }
    }
}