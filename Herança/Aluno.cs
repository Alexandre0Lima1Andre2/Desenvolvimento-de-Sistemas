using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança
{
    internal class Aluno : Pessoa
    {

        public int rm;
        public string curso;
        public string responsavel;
        protected string senha;

        public void definirSenha(string senha)
        {
            if (senha == "")
            {
                Console.WriteLine("Senha não pode ser alterada");
            }
            else
            {
                this.senha = senha;
                Console.WriteLine("Senha alterada");
            }
        }


        public void mostraCurso()
        {
            Console.WriteLine("\nCurso:{0}",curso);
        }

        public void cadastrar()
        {
            Console.WriteLine("Digite seu CPF:");
            this.cadastrarCpf(Console.ReadLine());
        }
    }
}
