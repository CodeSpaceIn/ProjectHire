using Dapper;
using HiringPortal.Core.Interfaces;
using HiringPortal.Core.Models;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace HiringPortal.Infrastructure.Repositories
{
    public class CandidateRepository : ICandidateRepository
    {
        // Make it possible to read a connection string from configuration
        private readonly IConfiguration _configuration;

        public CandidateRepository(IConfiguration configuration)
        {
            // Injecting Iconfiguration to the contructor of the product repository
            _configuration = configuration;
        }

        /// <summary>
        /// This method adds a new Candiadate to the database using Dapper
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>int</returns>
        public async Task<int> AddAsync(Candidate entity)
        {
            // Basic SQL statement to insert a product into the products table
            var sql = "Insert into dbo.Candidate (FirstName,LastName,EmailID,PrimarySkill,PhoneNumber,Active) VALUES (@FirstName,@LastName,@EmailID,@PrimarySkill,@PhoneNumber,@Active);";

            // Sing the Dapper Connection string we open a connection to the database
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DapperConnection")))
            {
                connection.Open();

                // Pass the product object and the SQL statement into the Execute function (async)
                var result = await connection.ExecuteAsync(sql, new  { FirstName = entity.FirstName, LastName =entity.LastName,EmailID= entity.EmailID, PrimarySkill=entity.PrimarySkill,Active= entity.Active,entity.PhoneNumber });
                return result;
            }
        }

        /// <summary>
        /// This method deleted a Candiadate specified by an ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>int</returns>
        public async Task<int> DeleteAsync(int id)
        {
            var sql = "DELETE FROM dbo.Candidates WHERE Id = @Id";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DapperConnection")))
            {
                connection.Open();
                var result = await connection.ExecuteAsync(sql, new { Id = id });
                return result;
            }
        }

        /// <summary>
        /// This method returns all Candiadate in database in a list object
        /// </summary>
        /// <returns>IEnumerable Product</returns>
        public async Task<IReadOnlyList<Candidate>> GetAllAsync()
        {
            var sql = "SELECT d.Id,d.[FirstName], d.[LastName],d.[EmailID],d.PrimarySkill,d.[PhoneNumber],d.[Address],d.[Active] from dbo.Candidate d;\r\n";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DapperConnection")))
            {
                connection.Open();

                // Map all products from database to a list of type Product defined in Models.
                // this is done by using Async method which is also used on the GetByIdAsync
                var result = await connection.QueryAsync<Candidate>(sql);
                return result.ToList();
            }
        }

        /// <summary>
        /// This method returns a single Candiadate specified by an ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Product</returns>
        public async Task<Candidate> GetByIdAsync(int id)
        {
            var sql = "SELECT d.Id,d.[FirstName], d.[LastName],d.[EmailID],d.PrimarySkill,d.[PhoneNumber],d.[Address],d.[Active] from dbo.Candidate d WHERE d.Id = @Id;";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DapperConnection")))
            {
                connection.Open();
                var result = await connection.QuerySingleOrDefaultAsync<Candidate>(sql, new { Id = id });
                return result;
            }
        }

        public Task<int> UpdateAsync(Candidate entity)
        {
            throw new NotImplementedException();
        }

        ///// <summary>
        ///// This method updates a product specified by an ID. Added column won't be touched.
        ///// </summary>
        ///// <param name="entity"></param>
        ///// <returns>int</returns>
        //public async Task<int> UpdateAsync(Candidate entity)
        //{
        //    entity.Modified = DateTime.Now;
        //    var sql = "UPDATE Products SET Name = @Name, Description = @Description, Barcode = @Barcode, Price = @Price, Modified = @Modified  WHERE Id = @Id";
        //    using (var connection = new SqlConnection(_configuration.GetConnectionString("DapperConnection")))
        //    {
        //        connection.Open();
        //        var result = await connection.ExecuteAsync(sql, entity);
        //        return result;
        //    }
        //}

    }
}
