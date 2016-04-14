using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliacao08
{ 
    class Banco
    {
        private int numero;
        private string nome;

        public Banco(int numero, string nome)
        {
            this.numero = numero;
            this.nome = nome;
        }

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

        public void Exibir()
        {
            Console.WriteLine("Banco:\t\t\t {0} ({1})", nome, numero);
        }
    }
}
