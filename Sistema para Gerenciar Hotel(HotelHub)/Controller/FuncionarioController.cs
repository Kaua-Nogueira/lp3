using Sistema_para_Gerenciar_Hotel_HotelHub_.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sistema_para_Gerenciar_Hotel_HotelHub_.Controller
{
    public class FuncionarioController
    {
        private List<Funcionario> listFunc = new List<Funcionario>();

        public FuncionarioController() { }

        // Adiciona um novo funcionário à lista
        public void AdicionarFuncionario(Funcionario funcionario)
        {
            if (funcionario == null)
            {
                throw new ArgumentNullException(nameof(funcionario), "Funcionário não pode ser nulo.");
            }

            // Gerar um ID único (aqui, apenas incrementamos, mas isso pode ser melhorado)
            funcionario.Id = listFunc.Count > 0 ? listFunc.Max(f => f.Id) + 1 : 1;
            listFunc.Add(funcionario);
        }

        // Atualiza um funcionário existente
        public void AtualizarFuncionario(Funcionario funcionario)
        {
            if (funcionario == null)
            {
                throw new ArgumentNullException(nameof(funcionario), "Funcionário não pode ser nulo.");
            }

            var funcionarioExistente = listFunc.FirstOrDefault(f => f.Id == funcionario.Id);
            if (funcionarioExistente == null)
            {
                throw new KeyNotFoundException("Funcionário não encontrado.");
            }

            funcionarioExistente.Name = funcionario.Name;
            funcionarioExistente.Sobrenome = funcionario.Sobrenome;
            funcionarioExistente.CPF = funcionario.CPF;
            funcionarioExistente.email = funcionario.email;
            funcionarioExistente.estadoCivil = funcionario.estadoCivil;
            funcionarioExistente.dataNasc = funcionario.dataNasc;
        }

        // Remove um funcionário pelo ID
        public void RemoverFuncionario(int id)
        {
            var funcionario = listFunc.FirstOrDefault(f => f.Id == id);
            if (funcionario == null)
            {
                throw new KeyNotFoundException("Funcionário não encontrado.");
            }

            listFunc.Remove(funcionario);
        }

        // Lista todos os funcionários
        public List<Funcionario> ListarFuncionarios()
        {
            return listFunc.ToList();
        }

        // Busca um funcionário pelo ID
        public Funcionario BuscarFuncionarioPorId(int id)
        {
            var funcionario = listFunc.FirstOrDefault(f => f.Id == id);
            if (funcionario == null)
            {
               MessageBox.Show("Funcionário não encontrado.");
            }

            return funcionario;
        }
    }
}
