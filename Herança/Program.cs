using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Pessoa p1 = new Pessoa();
            Aluno a1 = new Aluno();

            a1.cadastrarDados("Alexandre");//a1.cadastrarDados();
            a1.curso = "Engenharia de Software";
            a1.mostraDados();
            a1.mostraCurso();


            a1.definirSenha("olaMundo");
            a1.cadastrar();
            a1.mostrarCpf();


        }
    }
}
