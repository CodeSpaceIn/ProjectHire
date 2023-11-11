using Dapper;
using HiringPortal.Core.Interfaces;
using HiringPortal.Core.Models;
//using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace HiringPortal.Infrastructure.Repositories
{
    public class CandidateRepository : ICandidateRepository
    {
        // Make it possible to read a connection string from configuration
      //  private readonly IConfiguration _configuration;

        private SqlConnection connection;

        private IDbTransaction _dbTransaction;

        public CandidateRepository( IDbTransaction dbTransaction, SqlConnection sqlConnection)
        {
            

            //Transactions 
            _dbTransaction = dbTransaction;
            connection = sqlConnection;
        }


        /// <summary>
        /// This method adds a new Candiadate to the database using Dapper
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>int</returns>
        public async Task<int> AddAsync(Candidate entity)
        {
                var result = await connection.ExecuteAsync(CandidateQueries.CreateCandidate, new { FirstName = entity.FirstName, LastName = entity.LastName, EmailID = entity.EmailID, Active = entity.Active, entity.PhoneNumber },commandType:CommandType.Text,transaction:_dbTransaction);
                return result;
         
        }

        /// <summary>
        /// This method deleted a Candiadate specified by an ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>int</returns>
        public async Task<int> DeleteAsync(int id)
        {
            var result = await connection.ExecuteAsync(CandidateQueries.DeleteCandidate, new { Id = id }, commandType: CommandType.Text, transaction: _dbTransaction);
             return result;
        }

        /// <summary>
        /// This method returns all Candiadate in database in a list object
        /// </summary>
        /// <returns>IEnumerable Product</returns>
        public async Task<IReadOnlyList<Candidate>> GetAllAsync()
        {
          
            var result = await connection.QueryAsync<Candidate>(CandidateQueries.AllCandidates, commandType: CommandType.Text, transaction: _dbTransaction);
            return result.ToList();
            
        }

        /// <summary>
        /// This method returns a single Candiadate specified by an ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Product</returns>
        public async Task<Candidate> GetByIdAsync(int id)
        {
            
                var result = await connection.QuerySingleOrDefaultAsync<Candidate>(CandidateQueries.CandidateById, new { Id = id }, commandType: CommandType.Text, transaction: _dbTransaction);
                return result;
         
        }

        /// <summary>
        /// This method updates a canidiate specified by an ID. Added column won't be touched.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>int</returns>
        public async Task<int> UpdateAsync(Candidate entity)
        {
               entity.ModifiedBy = "dbuser";
                entity.ModifiedDate = DateTime.Now;

           
                var result = await connection.ExecuteAsync(CandidateQueries.UpdateCandidate, entity,commandType: CommandType.Text,transaction:_dbTransaction);
                return result;
       
        }


        public async Task<List<CandidatePrimarySkills>> GetAllCandidatesWithSkillsAsync()
        {

            var result = await connection.QueryAsync<CandidatePrimarySkills>(StoredProc.getAllCandidatesSkillset, commandType: CommandType.StoredProcedure, transaction: _dbTransaction);
            return result.ToList();

        }




    }
}
