using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HiringPortal.Core.Interfaces;
using Microsoft.Extensions.Configuration;

namespace HiringPortal.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork,IDisposable
    {
        public ICandidateRepository Candidate { get; }
          IDbTransaction _dbTransaction;

      //  private IDbConnection _connection;

       private readonly IConfiguration _configuration;

        public UnitOfWork(IDbTransaction dbTransaction,
                            ICandidateRepository candidateRepository   )
        {
            _dbTransaction = dbTransaction;
            Candidate = candidateRepository;

 
        }
       
        public int Commit()
        {
            try
            {
                _dbTransaction.Commit();
                // By adding this we can have muliple transactions as part of a single request
                _dbTransaction.Connection.BeginTransaction();

                return 1;
            }
            catch (Exception ex)
            {
               _dbTransaction.Rollback();

                return 0;
            }
        }

        public void Dispose()
        {
            //Close the SQL Connection and dispose the objects
            _dbTransaction.Connection?.Close();
            _dbTransaction.Connection?.Dispose();
            _dbTransaction.Dispose();
            GC.SuppressFinalize(this);
        }

    }
}
