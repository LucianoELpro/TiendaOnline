using Aplication.Features.Arqueo.Queries.ListarArqueoQuery;
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
    public class ArqueoRepository :IArqueoRepository
    {
        private readonly IConfiguration _config;
        public ArqueoRepository(IConfiguration config)
        {
            _config = config;
        }

        public IDbConnection _dbconnection { get { return new SqlConnection(_config.GetConnectionString("DbConnection")); } }

        public async Task<int> AperturaArqueo(Arqueo arqueo)
        {
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@iduser", arqueo.IdUsuario);
                parameters.Add("@idMasterCaja", arqueo.IdMasterCaja);
                int result = 0;
                using (var connection = _dbconnection)
                {
                    connection.Open();
                    result = await connection.ExecuteScalarAsync<int>("SpAperturaArqueo", parameters, commandType: CommandType.StoredProcedure);
                    connection.Close();
                }
                return result;

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<int> CierreArqueo(int idArqueo, decimal real, int idUsuario)
        {
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@idArqueo", idArqueo);
                parameters.Add("@Real", real);
                parameters.Add("@idUsuario", idUsuario);
                int result = 0;
                using (var connection = _dbconnection)
                {
                    connection.Open();
                    result = await connection.ExecuteAsync("SpCierreArqueo", parameters, commandType: CommandType.StoredProcedure);
                    connection.Close();
                }
                return result;

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<List<Arqueo>> ListarArqueo(ListarArqueoQuery predicado)
        {
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@IdUsuario", predicado.idUsuario);
                parameters.Add("@FechaIni", predicado.FechaIni);
                parameters.Add("@FechaFin", predicado.Fechafin);
                parameters.Add("@Anio", predicado.Anio);
                parameters.Add("@Mes", predicado.Mes);
                parameters.Add("@anio2", predicado.Anio2);
                parameters.Add("@mes2", predicado.Mes2);
                parameters.Add("@dia2", predicado.Dia2);
                parameters.Add("@PageNumber", predicado.PageNumber);
                parameters.Add("@PageSize", predicado.Pagesize);

                List<Arqueo> list1;
                using (var connection = _dbconnection)
                {
                    connection.Open();
                    var result =  await connection.QueryAsync<Arqueo>("SpListarArqueo", parameters, commandType: CommandType.StoredProcedure);
                     list1 = result.ToList();
                    connection.Close();

                    
                }
                return list1;

            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
