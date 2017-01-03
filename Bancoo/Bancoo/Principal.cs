using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bancoo
{
    class Principal
    {
        static void Main(string[] args)
        {
            Cliente cl = new Cliente();
            Conta ct = new Conta();

            Cliente cl2 = new Cliente();
            Conta ct2 = new Conta();

            ct.cliente = cl;
            ct2.cliente = cl2;

             
            ct.cliente.Nome = "João Victor";
            ct.cliente.Cpf = "048.521.261-78";
            ct.Numero = "123456";
            ct.Limite = "2.000";
            ct.Saldo = 3000.0;

            ct2.cliente.Nome = "Cesar Alves";
            ct2.cliente.Cpf = "580.255.208-13";
            ct2.Numero = "659842";
            ct2.Limite = "3.000";
            ct2.Saldo = 5000.0;

            ct2.Trasnferir(1000,ct);

            
            Console.WriteLine(ct.Extrato());
            Console.WriteLine(ct2.Extrato());



        }
    }
}
