using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliacao08
{
    class Agencia
    {
        private int numero;
        private string nome;
        private Banco banco;

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public Banco Banco
        {
            get { return banco; }
            set { banco = value; }
        }

        public Agencia(int numero, string nome, Banco banco)
        {
            this.numero = numero;
            this.nome = nome;
            this.banco = banco;
        }

        public void Exibir()
        {
            Console.WriteLine("Agência: \t\t {0} \t ({1})", Numero, Nome);
        }
    }
}
