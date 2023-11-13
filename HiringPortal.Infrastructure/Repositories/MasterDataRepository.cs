using Dapper;
using HiringPortal.Core.Interfaces;
using HiringPortal.Core.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiringPortal.Infrastructure.Repositories
{
   
    public class MasterDataRepository : IMasterDataRepository
    {
        // Make it possible to read a connection string from configuration
        //  private readonly IConfiguration _configuration;

        private SqlConnection connection;

        private IDbTransaction _dbTransaction;

        public MasterDataRepository(IDbTransaction dbTransaction, SqlConnection sqlConnection)
        {


            //Transactions 
            _dbTransaction = dbTransaction;
            connection = sqlConnection;
        }

        /// <summary>
        /// This method returns all Candiadate in database in a list object
        /// </summary>
        /// <returns>IEnumerable Product</returns>
        public async Task<List<HiringManger>> GetAllHiringMangerAsync()
        {

            var result = await connection.QueryAsync<HiringManger>(StoredProc.getMasterdata,new { @TYPE = MasterDataType.HiringManger },commandType: CommandType.StoredProcedure, transaction: _dbTransaction);
          
            return result.ToList();

        }

        public async Task<List<InterviewPanel>> GetInterviewPanelListAsync()
        {

            var result = await connection.QueryAsync<InterviewPanel>(StoredProc.getMasterdata, new { @TYPE = MasterDataType.InterviewPanel }, commandType: CommandType.StoredProcedure, transaction: _dbTransaction);

            return result.ToList();

        }


        
        //Task<int> IGenericRepository<MasterData>.AddAsync(MasterData entity)
        //{
        //    throw new NotImplementedException();
        //}

        //Task<int> IGenericRepository<MasterData>.DeleteAsync(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //Task<IReadOnlyList<MasterData>> IGenericRepository<MasterData>.GetAllAsync()
        //{
        //    throw new NotImplementedException();
        //}

        //Task<MasterData> IGenericRepository<MasterData>.GetByIdAsync(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //Task<int> IGenericRepository<MasterData>.UpdateAsync(MasterData entity)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
