using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSI.Modelo
{
    public class Funcionario
    {
        private int codigo;

        public int Codigo
        {
            get { return codigo; }
        }
        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        private string telefones;

        public string Telefones
        {
            get { return telefones; }
            set { telefones = value; }
        }
        private string identidade;

        public string Identidade
        {
            get { return identidade; }
            set { identidade = value; }
        }
        private string clt;

        public string Clt
        {
            get { return clt; }
            set { clt = value; }
        }
        private string salario;

        public string Salario
        {
            get { return salario; }
            set { salario = value; }
        }
        private bool motorista;

        public bool Motorista
        {
            get { return motorista; }
            set { motorista = value; }
        }
        private bool tecnico;

        public bool Tecnico
        {
            get { return tecnico; }
            set { tecnico = value; }
        }
        private string observacao;

        public string Observacao
        {
            get { return observacao; }
            set { observacao = value; }
        }

        public Funcionario(int codigo, string nome, string telefones, string identidade, string clt, string salario, bool motorista, bool tecnico, string observacao)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.telefones = telefones;
            this.identidade = identidade;
            this.clt = clt;
            this.salario = salario;
            this.motorista = motorista;
            this.tecnico = tecnico;
            this.observacao = observacao;
        }
    }
}