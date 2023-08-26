using Coti02.Entities;
using Coti02.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coti02.Controllers
{
    public class TurmaController
    {
        public void CriarTurma()
        {
            try
            {
                Console.WriteLine("***** Cadastro de Turma *****");

                Turma turma = new Turma();

                turma.Id = Guid.NewGuid();

                Console.Write("\nNome da turma.....: ");
                turma.Nome = Console.ReadLine();

                Console.Write("Data de Início da turma.....: ");
                turma.DataInicio = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("\n----- Cadastro de Professor -----");

                 turma.Professor = new Professor();

                turma.Professor.Id = Guid.NewGuid();


                Console.Write("Nome do professor.....: ");
                turma.Professor.Nome = Console.ReadLine();


                Console.Write("Telefone do professor.....: ");
                turma.Professor.Telefone = Console.ReadLine();

                Console.Write("CPF do professor.....: ");
                turma.Professor.Cpf = Console.ReadLine();

                var professorController = new ProfessorController();

                professorController.CadastrarProfessor(turma.Professor);

                Console.WriteLine("\nA turma já está apta a receber alunos!");

                Console.Write("\nDeseja exportar os dados para formato XML?");
                string export = Console.ReadLine();

                if (export.Equals("S", StringComparison.OrdinalIgnoreCase))
                {
                    var turmaRepository = new TurmaRepository();

                    turmaRepository.ExportToXml(turma);
                }


            }
            catch (ArgumentException error)
            {
                Console.WriteLine("Erro ao criar turma. Verifique o preenchimento dos campos e tente novamente.");
                Console.WriteLine(error.Message);
            }
            catch (Exception error)
            {
                Console.WriteLine("Erro durante a execução do programa.");
                Console.WriteLine(error.Message);
            }

            finally
            {
                Console.Write("Deseja continuar? (S/N)");

                string option = Console.ReadLine();

                if (option.Equals("S", StringComparison.OrdinalIgnoreCase))
                {
                    Console.Clear();
                    CriarTurma();
                }
                else
                {
                    Console.WriteLine("\nFim da execução do programa.");
                }

            }
        }
    }
}
