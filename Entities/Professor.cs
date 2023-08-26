using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Coti02.Entities
{
    public class Professor
    {
        private Guid _id;
        private string _nome;
        private string _telefone;
        private string _cpf;

        public Guid Id
        {
            set
            {
                if (value == Guid.Empty)
                    throw new ArgumentException("É necessário gerar o ID do Professor.");
                _id = value;
            }
            get { return _id; }
        }

        public string Nome
        {
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("É necessário inserir o nome do Professor.");
                var regex = new Regex("^[A-Za-z\\s]{8,50}$");

                if (!regex.IsMatch(value))
                    throw new ArgumentException("O nome precisa ter entre 8 e 50 caracteres. Não é permitido o uso de caracteres especiais.");

                _nome = value;
            }
            get { return _nome; }
        }

        public string Telefone
        {
                        set 
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("É necessário inserir o telefone do professor.");
                var regex = new Regex("^[0-9]{9,11}$");

                if (!regex.IsMatch(value))
                    throw new ArgumentException("O número de telefone deve ter no máximo 11 dígitos");

                _telefone = value;
            }
            get { return  _telefone; }
        }

        public string Cpf
        {
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("É necessário inserir o CPF do professor.");
                var regex = new Regex("^[0-9]{11}$");

                if (!regex.IsMatch(value))
                    throw new ArgumentException("O CPF precisa ter exatamente 11 dígitos.");

                _cpf = value;
            }
            get { return _cpf; }
        }
    }
}
