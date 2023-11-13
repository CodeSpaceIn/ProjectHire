using HiringPortal.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiringPortal.Services.Interfaces
{
    public interface IMasterDataSerivice

    {

        Task<List<HiringManger>> GetAllHiringMangerAsync();

        Task<List<InterviewPanel>> GetAllInterviewpanelAsync();

    }
}
