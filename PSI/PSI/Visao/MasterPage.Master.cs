﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSI.Visao
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Url.AbsolutePath.Contains("CadastroCliente")) li1.Attributes["class"] = "active";
            else if (Request.Url.AbsolutePath.Contains("CadastroFuncionario")) li2.Attributes["class"] = "active";
            else if (Request.Url.AbsolutePath.Contains("PagamentoSalario")) li3.Attributes["class"] = "active";
            else if (Request.Url.AbsolutePath.Contains("CadastroFornecedor")) li4.Attributes["class"] = "active";
            else if (Request.Url.AbsolutePath.Contains("CadastroProduto")) li5.Attributes["class"] = "active";
        }
    }
}