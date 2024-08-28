using Sistema_para_Gerenciar_Hotel_HotelHub_.Model.DAO;
using Sistema_para_Gerenciar_Hotel_HotelHub_.Model.DTO;
using Sistema_para_Gerenciar_Hotel_HotelHub_.Model.UserViewsDTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sistema_para_Gerenciar_Hotel_HotelHub_.Controller
{
    public class FuncionarioController
    {
        public FuncionarioController() { }

        public bool AdicionarFuncionario(string nome, string sobrenome, string cpf, string email,DateTime dataNascimento, string estadoCivil)
        {
            FuncionarioDTO funcionarioDTO = new FuncionarioDTO(nome, sobrenome, cpf, email, dataNascimento, estadoCivil);
            FuncionarioDAO funcionarioDAO = new FuncionarioDAO();
            if (!funcionarioDAO.AdicionarFuncionarioBd(funcionarioDTO))
            {
                return false;
            }

            return true;
        }

        public bool AtualizarFuncionario(int id, string nome, string sobrenome, string cpf, string email, DateTime dataNascimento, string estadoCivil)
        {
            FuncionarioDTO funcionarioDTO = new FuncionarioDTO(id, nome, sobrenome, cpf, email,dataNascimento, estadoCivil);
            FuncionarioDAO funcionarioDAO = new FuncionarioDAO();
            if (!funcionarioDAO.AlterarFuncionarioBd(funcionarioDTO))
            {
                return false;
            }

            return true;
        }

        public bool RemoverFuncionario(int id)
        {
            FuncionarioDAO funcDao = new FuncionarioDAO();
            if (!funcDao.DeletarFuncionario(id))
            {
                return false;
            }
            return true;
        }

        internal FuncionarioDTO BuscarFuncionarioPorId(int id)
        {
            FuncionarioDAO funcDao = new FuncionarioDAO();
            FuncionarioDTO dto = funcDao.BuscarFuncionario(id);
            if (dto == null)
            {
                throw new KeyNotFoundException("Funcionário não encontrado.");
            }

            return dto;
        }

        public List<Funcionario> ListarFuncionarios()
        {
            FuncionarioDAO funcDao = new FuncionarioDAO();
            List<FuncionarioDTO> funcionariosDTO = funcDao.ListarFuncionarios();
            List<Funcionario> funcList = new List<Funcionario>();

            foreach (var dto in funcionariosDTO)
            {
                Funcionario funcionario = new Funcionario();
                funcionario.Id = dto.Id;
                funcionario.Name = dto.Nome;
                funcionario.Sobrenome = dto.Sobrenome;
                funcionario.CPF = dto.Cpf;
                funcionario.email = dto.Email;
                funcionario.dataNasc = dto.DataNascimento;
                funcionario.estadoCivil = dto.EstadoCivil;

                funcList.Add(funcionario);
            }

            return funcList;
        }
    }

}
