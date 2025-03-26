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

     
        protected string nome;
        public string email;
        public string idade;
        private string cpf;
        public string altura;
        public string peso;
        

        public void mostraDados()
        {
   
            Console.WriteLine("Nome:{0}",nome);

        }

        public void cadastrarDados(string nome)
        {
            this.nome = nome;
        }

        
        public void cadastrarCpf(string cpf)
        {
                this.cpf = cpf;
        }
        public void mostrarCpf()
        {
        Console.WriteLine("CPF:{0}", cpf);
        }






    }
}
