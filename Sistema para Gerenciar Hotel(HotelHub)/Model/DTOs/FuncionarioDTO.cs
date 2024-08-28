using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_para_Gerenciar_Hotel_HotelHub_.Model.DTO
{
    internal class FuncionarioDTO
    {
        private int id;
        private string nome;
        private string sobrenome;
        private string cpf;
        private string email;
        private DateTime data_nasc;
        private string estado_civil;

        //Construtor para adição ou consulta
        public FuncionarioDTO(string nome, string sobrenome, string cpf, string email
                             ,DateTime data_nasc, string estado_civil)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.cpf = cpf;
            this.email = email;
            this.data_nasc = data_nasc;
            this.estado_civil = estado_civil;

        }
        public FuncionarioDTO(int Id, string nome, string sobrenome, string cpf, string email
                             ,DateTime data_nasc, string estado_civil)
        {
            this.id = Id;
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.cpf = cpf;
            this.email = email;
            this.data_nasc = data_nasc;
            this.estado_civil = estado_civil;

        }

        //Getter and Setter pra acessar os atributos


        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Sobrenome { get => sobrenome; set => sobrenome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Email { get => email; set => email = value; }
        public DateTime DataNascimento { get => data_nasc; set => data_nasc = value; }
        public string EstadoCivil { get => estado_civil; set => estado_civil = value; }
    }
}
