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
    public class ProductoRepository : IProductoRepository
    {
        private readonly IConfiguration _config;
        public ProductoRepository(IConfiguration config)
        {
            _config = config;
        }

        public IDbConnection _dbconnection { get { return new SqlConnection(_config.GetConnectionString("DbConnection")); } }


        public async Task<List<Producto>> ListarProducto(string nombre)
        {
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@nombre", nombre);

                List<Producto> list;
                using (var connection = _dbconnection)
                {
                    connection.Open();
                   var result = await connection.QueryAsync<Producto>("SpListarProductos", parameters, commandType: CommandType.StoredProcedure);
                    list = result.ToList();
                    connection.Close();
                }
                return list;

            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
