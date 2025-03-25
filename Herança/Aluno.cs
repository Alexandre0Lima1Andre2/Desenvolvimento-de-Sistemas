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


        public void mostraCurso()
        {
            Console.WriteLine("\nCurso:{0}",curso);
        }
    }
}
