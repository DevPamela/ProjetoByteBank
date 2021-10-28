

using ByteBank.funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario carlos = new Funcionario();
            carlos.Nome = "Carlos";
            carlos.Cpf = "302.258.157-20";
            carlos.Salario = 2000;

            diretor marcos = new diretor();
            marcos.Nome = "Marcos()"; 
            marcos.Cpf = "580.854.236.52";
            marcos.Salario = 20000;
               
            Console.WriteLine(carlos.Nome);
            Console.WriteLine(carlos.GetBonificacao());

            Console.WriteLine(marcos.Nome);
            Console.WriteLine(marcos.GetBonificacao());

            Console.ReadKey();
            //para corrigir erro usar ctrl + .
        }
    }
}
