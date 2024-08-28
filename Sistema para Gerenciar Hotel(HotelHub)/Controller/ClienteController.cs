using Sistema_para_Gerenciar_Hotel_HotelHub_.Model.DAO;
using Sistema_para_Gerenciar_Hotel_HotelHub_.Model.DTO;
using Sistema_para_Gerenciar_Hotel_HotelHub_.Model.UserViewsDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_para_Gerenciar_Hotel_HotelHub_.Controller
{
    public class ClienteController
    {
        
        public ClienteController() { }

        public bool adicionarCliente (string nome, string sobrenome, string cpf, string email, string telefone, DateTime dataNascimento, string estadoCivil)
        {

            ClienteDTO clienteDTO = new ClienteDTO(nome, sobrenome, cpf, email, telefone, dataNascimento, estadoCivil);
            ClienteDAO clienteDAO = new ClienteDAO();
            if (!clienteDAO.AdicionarClienteBd(clienteDTO))
            {
                return false;
            }

            return true;
        }

        public bool atualizarcliente(int id, string nome, string sobrenome, string cpf, string email, string telefone, DateTime dataNascimento, string estadoCivil)
        {
            
                ClienteDTO clienteDTO = new ClienteDTO(id, nome, sobrenome, cpf, email, telefone, dataNascimento, estadoCivil);
                ClienteDAO clienteDAO = new ClienteDAO();
                if (!clienteDAO.alterarClienteBd(clienteDTO))
                {
                    return false; 
                }
               
            
            return true;
        }
        public bool RemoverCliente(int id)
        {
            ClienteDAO cliDao = new ClienteDAO();
            if(!cliDao.deletarCliente(id))
            {
                return false;
            }
            return true;
        }
        internal ClienteDTO BuscarClientePorId(int id)
        {
            ClienteDAO cliDao = new ClienteDAO();
            ClienteDTO dto = cliDao.buscarCliente(id);
            if (dto == null)
            {
                throw new KeyNotFoundException("Cliente não encontrado.");
            }
            

             return (ClienteDTO) dto;
         
        }
        public List<Cliente> Listarclientes()
        {
            ClienteDAO cliDao = new ClienteDAO();
            List<ClienteDTO> clientesDTO = cliDao.listarClientes();
            List<Cliente> cliList = new List<Cliente>();

            foreach (var dto in clientesDTO)
            {
                Cliente cliente = new Cliente();
                cliente.Id = dto.Id;
                cliente.Nome = dto.Nome;
                cliente.Sobrenome = dto.Sobrenome;
                cliente.Cpf = dto.Cpf;
                cliente.Telefone = dto.Telefone;
                cliente.Email = dto.Email;
                cliente.DataNascimento = dto.DataNascimento;
                cliente.estadoCivil = dto.EstadoCivil;

                cliList.Add(cliente);
            }

            return cliList;
            
        }

        public Cliente toCliente(ClienteDTO dto)
        {
            Cliente cli = new Cliente
            {
                Id = dto.Id,
                Nome = dto.Nome,
                Sobrenome = dto.Sobrenome,
                Cpf = dto.Cpf,
                Telefone = dto.Telefone,
                Email = dto.Email,
                DataNascimento = dto.DataNascimento,
                estadoCivil = dto.EstadoCivil,
            };

            return cli;
        }
    }
}
