using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_para_Gerenciar_Hotel_HotelHub_.Model.DTO
{
    public class ClienteDTO
    {
        private int id;
        private string nome;
        private string sobrenome;
        private string cpf;
        private string email;
        private string telefone;
        private DateTime dataNascimento;
        private string estadoCivil;

        public ClienteDTO()
        {

        }

        public ClienteDTO(string nome, string sobrenome, string cpf, string email, string telefone, DateTime dataNascimento, string estadoCivil) 
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.cpf = cpf;
            this.email = email;
            this.telefone = telefone;
            this.dataNascimento = dataNascimento;
            this.estadoCivil = estadoCivil;
        }

        
        public ClienteDTO(int id, string nome, string sobrenome, string cpf, string email, string telefone, DateTime dataNascimento, string estadoCivil)
        {
            this.id = id;
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.cpf = cpf;
            this.email = email;
            this.telefone = telefone;
            this.dataNascimento = dataNascimento;
            this.estadoCivil = estadoCivil;
        }

        
        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Sobrenome { get => sobrenome; set => sobrenome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Email { get => email; set => email = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public DateTime DataNascimento { get => dataNascimento; set => dataNascimento = value; }
        public string EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
    }

}
