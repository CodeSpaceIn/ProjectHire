using HiringPortal.Core.Models;

namespace HiringPortal.Core.Interfaces
{
    public interface ICandidateRepository : IGenericRepository<Candidate>
    {
       Task<List<CandidatePrimarySkills>> GetAllCandidatesWithSkillsAsync();
    }
}
