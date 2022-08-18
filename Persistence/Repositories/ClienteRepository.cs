using Aplication.Interfaces;
using Dapper;
using Domain.Entities;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly IConfiguration _config;
        public ClienteRepository(IConfiguration config)
        {
            _config = config;
        }

        public IDbConnection _dbconnection { get { return new SqlConnection(_config.GetConnectionString("DbConnection")); } }

        public async Task<List<Cliente>> BuscarCliente(string nombre)
        {
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@nombre", nombre);

                List<Cliente> result;
                using (var connection = _dbconnection)
                {
                    connection.Open();
                    var List =   await connection.QueryAsync<Cliente>("SpBuscarCliente", parameters, commandType: CommandType.StoredProcedure);
                    result = List.ToList();
                    connection.Close();
                }
                return result;

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<int> CrearCliente(Cliente cliente)
        {
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@IdMasterTipoPersona", cliente.IdMasterTipoPersona);
                parameters.Add("@nombre", cliente.Nombre);
                parameters.Add("@AppePaterno", cliente.AppePaterno);
                parameters.Add("@AppeMaterno", cliente.AppeMaterno);
                parameters.Add("@telefono", cliente.Telefono);
                parameters.Add("@direccion", cliente.Direccion);
                parameters.Add("@IdMasterGenero", cliente.IdMasterGenero);
                parameters.Add("@Email", cliente.Email);
                parameters.Add("@FechaNacimiento", cliente.FechaNac);
                parameters.Add("@idUsuario", cliente.idUsuario);


                 int result;
                using (var connection = _dbconnection)
                {
                    connection.Open();
                    result = await connection.ExecuteScalarAsync<int>("SpCrearCliente", parameters, commandType: CommandType.StoredProcedure);
                    connection.Close();
                }
                return result;

            }
            catch (Exception ex)
            {

                throw;
            }
        }

    }
}
