using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bancoo
{
    class Conta
    {
        //public StringBuilder Extrato = new StringBuilder();
        public Cliente cliente;
        string numero;
        string limite;
        double saldo;

        public string Numero { get; set; }
        public string Limite { get; set; }
        public double Saldo { get; set; }

        public void Depositar(Double valor)
        {
            this.Saldo += valor;
        }
        public void Sacar(Double valor)
        {
            this.Saldo -= valor;
        }
        public void Trasnferir(Double valor, Conta destino)
        {
            Saldo -= valor;
            destino.Depositar(valor);
        }
     

        public StringBuilder Extrato()
        {
            return  new StringBuilder
            ("\n================================================\n").Append("\t\tDADOS CLIENTE").Append("\n================================================\n")
            .Append("Nome: ").Append(cliente.Nome)
            .AppendLine()
            .Append("Cpf: ").Append(cliente.Cpf)
            .AppendLine()
            .Append("N° Conta: ").Append(this.Numero)
            .AppendLine()
            .Append("Saldo: ").Append(this.Saldo)
            .AppendLine()
            .Append("Limite: ").Append(this.Limite+"\n");
        }        
    }
}
