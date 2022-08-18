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
    public class PedidoRepository : IPedidoRepository
    {
        private readonly IConfiguration _config;
        public PedidoRepository(IConfiguration config)
        {
            _config = config;
        }

        public IDbConnection _dbconnection { get { return new SqlConnection(_config.GetConnectionString("DbConnection")); } }


        public async Task<int> CrearPedido(Pedido pedido)
        {
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@idArqueo", pedido.IdArqueo);
                parameters.Add("@idCliente", pedido.IdCliente);
                parameters.Add("@idMasterTipoPedido", pedido.IdMasterTipoPedido);
                parameters.Add("@idUser", pedido.IdUser);
                parameters.Add("@direccion", pedido.Direccion);
                parameters.Add("@telefono", pedido.Telefono);

                int result;
                using (var connection = _dbconnection)
                {
                    connection.Open();
                    result = await connection.ExecuteScalarAsync<int>("SpCrearPedido", parameters, commandType: CommandType.StoredProcedure);
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
