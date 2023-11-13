using HiringPortal.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiringPortal.Core.Interfaces
{
    public interface IMasterDataRepository 
    {

        Task<List<HiringManger>> GetAllHiringMangerAsync();

        Task<List<InterviewPanel>> GetInterviewPanelListAsync();
    }
}
