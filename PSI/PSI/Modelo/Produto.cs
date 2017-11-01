using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSI.Modelo
{
    public class Produto
    {
        private int codigo;

        public int Codigo
        {
            get { return codigo; }
        }
        private string descricao;

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public Produto(int codigo, string descricao)
        {
            this.codigo = codigo;
            this.descricao = descricao;
        }
    }
}