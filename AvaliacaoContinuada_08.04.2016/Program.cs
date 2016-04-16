using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliacao08
{
    class Program
    {
        static void Main(string[] args)
        {
            Banco banco = new Banco(237,"BRADESCO");
            Agencia agencia = new Agencia(2818, "PLANALTO PAULISTA", banco);
            Cliente cliente1 = new Cliente("FERNANDO ALVES DA SILVA", "309.856.998-78");
            Cliente cliente2 = new Cliente("PAULA FERNANDES DA SILVA", "339.836.238-18");
           
            /*                                       banco  agencia  c/c    cliente    especial   limite     */
            ContaBancaria conta1 = new ContaBancaria(banco, agencia, 28165, cliente1,  true,      200f);
            ContaBancaria conta2 = new ContaBancaria(banco, agencia, 28164);
            conta1.addCliente(cliente2);
           
            conta1.Depositar(100f);
            conta1.Sacar(50f);
            conta1.Transferir(conta2, 20f);

            conta1.ExibirSaldo();
            Console.WriteLine(""); //Pula linha
            conta2.ExibirSaldo();
            Console.ReadKey();
        }
    }
}

