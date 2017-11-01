using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSI.Modelo
{
    public class Cliente
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
        private string cidade;

        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }
        private string estado;

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        private string endereco;

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }
        private string cpf_cnpj;

        public string Cpf_cnpj
        {
            get { return cpf_cnpj; }
            set { cpf_cnpj = value; }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public Cliente(int codigo, string nome, string telefones, string cidade, string estado, string endereco, string cpf_cnpj, string email) 
        {
            this.codigo = codigo;
            this.nome = nome;
            this.telefones = telefones;
            this.cidade = cidade;
            this.estado = estado;
            this.endereco = endereco;
            this.cpf_cnpj = cpf_cnpj;
            this.email = email;
        }
    }
}