using HiringPortal.Core.Interfaces;
using HiringPortal.Core.Models;
using HiringPortal.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiringPortal.Services
{

    public class MasterDataService : IMasterDataSerivice
    {
        public IUnitOfWork _unitOfWork;

        public MasterDataService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        public async Task<List<HiringManger>> GetAllHiringMangerAsync()
        {
            //Get Candidate List
            var HiringList = await _unitOfWork.MasterData.GetAllHiringMangerAsync();
            //Get Hiring Manger  List
         

         
            return HiringList;
        }


        public async Task<List<InterviewPanel>> GetAllInterviewpanelAsync()
        {
            //Get Candidate List
            var panellist = await _unitOfWork.MasterData.GetInterviewPanelListAsync();
            //Get Interview panel List



            return panellist;
        }


    }
}
