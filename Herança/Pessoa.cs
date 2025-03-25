using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Herança
{
    internal class Pessoa
    {
       

        public string nome;
        public string email;
        public string idade;
        public string cpf;
        public string altura;
        public string peso;

        public void mostraDados()
        {
            Console.WriteLine("Nome:{0}",nome);

        }
        
        
       


    }
}
