
using HiringPortal.Core.Interfaces;

namespace HiringPortal.Core.Interfaces
{
    public interface IUnitOfWork 
    {
        ICandidateRepository Candidate { get; }

        IMasterDataRepository MasterData { get; }
        int Commit();

    }
}
