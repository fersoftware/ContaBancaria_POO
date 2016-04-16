using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliacao08
{
    class ContaBancaria
    {
        private int numero;
        private Agencia agencia;
        //private Cliente cliente;
        private List<Cliente> Clientes = new List<Cliente>();
        private Boolean especial = false;
        private float limite = 0, saldo;   

        public ContaBancaria(Banco banco, Agencia agencia, int numero, Cliente cliente, bool especial, float limite)
        {          
            this.agencia = agencia;
            this.numero = numero;
            Clientes.Add(cliente);
            this.especial = especial;
            this.limite = limite;
        }
                

        public ContaBancaria(Banco banco, Agencia agencia, int numero, Cliente cliente)
        {            
            this.agencia = agencia;
            this.numero = numero;
            Clientes.Add(cliente);
        }


        
        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public Agencia Agencia
        {
            get { return agencia; }
            set { agencia = value; }
        }

       

        public bool Especial
        {
            get { return especial; }
            //set { especial = value; }
        }

        public float Limite
        {
            get { return limite; }
            //set { limite = value; }
        }

        public float Saldo
        {
            get { return saldo; }
            //set { saldo = value; }
        }

        public void ExibirSaldo()
        {
            Agencia.Banco.Exibir();
            Agencia.Exibir();
            
            /* não está na lista, coloquei por conta */
            Console.WriteLine("Conta Corrente:\t\t {0}", this.Numero);
            
            foreach(var item in Clientes )
            {
                Console.WriteLine("Nome {0}  - CPF {1}", item.Nome, item.Cpf);
            }

            Console.WriteLine("Saldo Atual: \t\t {0:C}", this.Saldo);
            if (this.Especial)
            {
                Console.WriteLine("Limite:\t\t\t {0:C}", this.Limite);
                Console.WriteLine("Saldo Total:\t\t {0:C}", this.Saldo + this.Limite);
            }
        }

        public bool Depositar(float valor)
        {
            if(valor > 0)
            {
                this.saldo += valor;
                return true;
            }            
            return false;
        }

        public bool Sacar(float valor)
        {
            if (Especial)
            {
                if (valor > 0 && valor <= (Limite + saldo))
                {
                    this.saldo -= valor;
                    return true;
                }
            }
            else
            {
                if (valor > 0 && Saldo >= valor)
                {
                    this.saldo -= valor;
                    return true;
                }
            }
            return false;
        }

        public bool Transferir(ContaBancaria cD, float valor)
        {
            if (this.Sacar(valor) && valor > 0)
            {
                cD.saldo += valor;
                return true;
            }
            return false;
        }
    }
}
