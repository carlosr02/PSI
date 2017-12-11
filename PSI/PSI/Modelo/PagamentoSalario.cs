using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSI.Modelo
{
    public class PagamentoSalario
    {
        private int codigo;

        public int Codigo
        {
            get { return codigo; }
        }
        private DateTime data;

        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }
        private int mesReferente;

        public int MesReferente
        {
            get { return mesReferente; }
            set { mesReferente = value; }
        }
        private int anoReferente;

        public int AnoReferente
        {
            get { return anoReferente; }
            set { anoReferente = value; }
        }
        private double valorPago;

        public double ValorPago
        {
            get { return valorPago; }
            set { valorPago = value; }
        }
        private int funcionario_codigo;

        public int Funcionario_codigo
        {
            get { return funcionario_codigo; }
        }
        private string funcionario_nome;

        public string Funcionario_nome
        {
            get { return funcionario_nome; }
        }

        public PagamentoSalario(int codigo, DateTime data, int mesReferente, int anoReferente, double valorPago, int funcionario_codigo)
        {
            this.codigo = codigo;
            this.data = data;
            this.mesReferente = mesReferente;
            this.anoReferente = anoReferente;
            this.valorPago = valorPago;
            this.funcionario_codigo = funcionario_codigo;
        }

        public PagamentoSalario(int codigo, DateTime data, int mesReferente, int anoReferente, double valorPago, int funcionario_codigo, string funcionario_nome)
        {
            this.codigo = codigo;
            this.data = data;
            this.mesReferente = mesReferente;
            this.anoReferente = anoReferente;
            this.valorPago = valorPago;
            this.funcionario_codigo = funcionario_codigo;
            this.funcionario_nome = funcionario_nome;
        }
    }
}