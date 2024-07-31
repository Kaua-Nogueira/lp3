using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_para_Gerenciar_Hotel_HotelHub_.Model
{
    internal class Usuario
    {
        private String nome { get; set; } = string.Empty;
        private String senha { get; set; } = string.Empty;
        private String cargo { get; set; } = string.Empty;

        public Usuario(string nome, string senha, string cargo)
        {
            this.nome = nome;
            this.senha = senha;
            this.cargo = cargo;
        }

        public string getNome()
        {
            return nome;
        }

        public string getSenha() 
        { 
            return senha;
        }
    }
}
