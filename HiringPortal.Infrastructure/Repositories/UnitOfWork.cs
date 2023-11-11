using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HiringPortal.Core.Interfaces;

namespace HiringPortal.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AdoNetContext _dbContext;
        //public ICandidateRepository Candidate { get; }

        public UnitOfWork(AdoNetContext dbContext,
                            ICandidateRepository candidateRepository)
        {
            _dbContext = dbContext;
            Candidate = candidateRepository;
        }

        public int Save()
        {
            try
            {
                //_dbContext.SaveChanges();
                 return 1;
            }
            catch {

                return 0;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                //_dbContext.Dispose();
            }
        }


        public UnitOfWork(ICandidateRepository candidateRepository)
            {
              Candidate = candidateRepository;
           }

           public ICandidateRepository Candidate { get; }

    }
}
