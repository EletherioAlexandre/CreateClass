using Coti02.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coti02.Controllers
{
    public class ProfessorController
    {
        public void CadastrarProfessor(Professor professor)
        {
            try
            {
                Console.WriteLine($"\nCadastro do professor {professor.Nome} realizado com sucesso!");

            }
            catch (ArgumentException error)
            {
                Console.WriteLine("Erro ao cadastrar professor. Verifique o preenchimento dos campos e tente novamente.");
                Console.WriteLine(error.Message);
            }
            catch(Exception error) 
            {
                Console.WriteLine("Erro durante a execução do programa.");
                Console.WriteLine(error.Message);
            }
        }
    }
}
