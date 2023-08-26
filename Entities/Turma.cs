using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Coti02.Entities
{
    public class Turma
    {
        private Guid _id;
        private string _nome;
        private DateTime _dataInicio;
        private Professor _professor;

        public Guid Id
        {
            set
            {
                if (value == Guid.Empty)
                    throw new ArgumentException("O cadastro do ID da turma é obrigatório.");
                _id = value;
            }
            get { return _id; }
        }

        public string Nome
        {
            set 
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("O cadastro do nome da turma é obrigatório.");
                var regex = new Regex("^[A-Za-z\\s]{8,50}$");

                if (!regex.IsMatch(value))
                    throw new ArgumentException("O nome precisa ter entre 8 e 50 caracteres. Não é permitido o uso de caracteres especiais.");

                _nome = value;
            }
            get { return _nome; }
        }

        public DateTime DataInicio
        {
            set 
            {
                var dataAtual = DateTime.Now;
                if (value < new DateTime(dataAtual.Year, dataAtual.Month, dataAtual.Day, 0, 0, 0))
                    throw new ArgumentException("A data de início não pode ser menor que a data de hoje.");
                _dataInicio = dataAtual;
            }
            get { return _dataInicio; }
        }

        public Professor Professor
        {
            set
            {
                _professor = value;
            }

            get { return _professor; }  
        }

    }
}
