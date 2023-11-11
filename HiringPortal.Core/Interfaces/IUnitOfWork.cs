
using HiringPortal.Core.Interfaces;

namespace HiringPortal.Core.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        ICandidateRepository Candidate { get; }
        int Save();
    }
}
