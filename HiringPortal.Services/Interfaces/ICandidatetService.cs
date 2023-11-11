using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HiringPortal.Core.Models;

namespace HiringPortal.Services.Interfaces
{
    public interface ICandidateService
    {
        Task<bool> CreateCandidate(Candidate candidate);

        Task<IEnumerable<Candidate>> GetAllCandidates();

        Task<Candidate> GetCandidateById(int id);

        Task<bool> UpdateCandidate(Candidate candidate);

        Task<bool> DeleteCandidate(int id);

       
    }
}
