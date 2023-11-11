
using HiringPortal.Core.Interfaces;

namespace HiringPortal.Core.Interfaces
{
    public interface IUnitOfWork 
    {
        ICandidateRepository Candidate { get; }
        int Commit();

    }
}
