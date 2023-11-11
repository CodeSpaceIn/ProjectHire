
using HiringPortal.Core.Interfaces;
using HiringPortal.Core.Models;
using HiringPortal.Services.Interfaces;

namespace HiringPortal.Services
{
    public class CandidateService : ICandidateService
    {
        public IUnitOfWork _unitOfWork;

        public CandidateService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> CreateCandidate(Candidate candidate)
        {
            if (candidate != null)
            {
                await _unitOfWork.Candidate.AddAsync(candidate);

                var result = _unitOfWork.Commit();

                if (result > 0)
                    return true;
                else
                    return false;
            }
            return false;
        }

        public async Task<bool> DeleteCandidate(int id)
        {
            if (id > 0)
            {
                
                    await _unitOfWork.Candidate.DeleteAsync(id);
                      var result = _unitOfWork.Commit();

                    if (result > 0)
                        return true;
                    else
                        return false;
                
            }
            return false;
        }

        public async Task<IEnumerable<Candidate>> GetAllCandidates()
        {
             //Get Candidate List
            var CandidateList = await _unitOfWork.Candidate.GetAllAsync();
            //Get canididates with Primary skill List
            var PrimarySkillList = await _unitOfWork.Candidate.GetAllCandidatesWithSkillsAsync();

            CandidateList = GetCandiateWithSkillset(CandidateList, PrimarySkillList);
            return CandidateList;
        }


        public IReadOnlyList<Candidate> GetCandiateWithSkillset(IReadOnlyList<Candidate> CandiateList, List<CandidatePrimarySkills> PrimarySkillList)
        {
            if (CandiateList != null && PrimarySkillList != null)
            {
                foreach (var candidate in CandiateList)
                {

                    candidate.PrimarySkills = PrimarySkillList.Where(x => x.CandidateID == candidate.Id).ToList();

                }
            }

            return CandiateList;

        }
        public async Task<Candidate> GetCandidateById(int id)
        {
            if (id > 0)
            {
                var productDetails = await _unitOfWork.Candidate.GetByIdAsync(id);
                if (productDetails != null)
                {
                    return productDetails;
                }
            }
            return null;
        }

        public async Task<bool> UpdateCandidate(Candidate candidate)
        {
            if (candidate != null)
            {
                var can = await _unitOfWork.Candidate.GetByIdAsync(candidate.Id);
                if (can != null)
                {
                    can.FirstName= candidate.FirstName;
                    can.LastName = can.LastName;
                    can.PhoneNumber = candidate.PhoneNumber;
                    can.Address = candidate.Address;
                    can.EmailID = candidate.EmailID;
                    can.ModifiedBy = "dbuser";
                    can.ModifiedDate = candidate.ModifiedDate;

                   await  _unitOfWork.Candidate.UpdateAsync(candidate);

                    var result = _unitOfWork.Commit();

                    if (result > 0)
                        return true;
                    else
                        return false;
                }
            }
            return false;
        }
    }
}
