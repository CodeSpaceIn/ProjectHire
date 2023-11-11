using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

                var result = _unitOfWork.Save();

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
                      var result = _unitOfWork.Save();

                    if (result > 0)
                        return true;
                    else
                        return false;
                
            }
            return false;
        }

        public async Task<IEnumerable<Candidate>> GetAllCandidates()
        {
            var CandiateList = await _unitOfWork.Candidate.GetAllAsync();
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
                    //product.ProductName= productDetails.ProductName;
                    //product.ProductDescription= productDetails.ProductDescription;
                    //product.ProductPrice= productDetails.ProductPrice;
                    //product.ProductStock= productDetails.ProductStock;

                   await  _unitOfWork.Candidate.UpdateAsync(candidate);

                    var result = _unitOfWork.Save();

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
