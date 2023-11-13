using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiringPortal.Core.Models
{
    public class MasterData
    {

        List<object>? masterData { get; set; }
    }



    public class HiringManger
    {
        public int Id { get; set; }
        public string? ManagerName { get; set; }
        public string?  EmailId { get; set; }

        public string? ModifiedBy { get; set; }
        public DateTime ModiifedDate { get; set; }

    }



    public class Skill
    {


      
        public int SkillId { get; set; }
        public string? SkillName { get; set; }

        public string? ModifiedBy { get; set; }
        public DateTime ModiifedDate { get; set; }

    }

    public class InterviewPanel
    {

        public int Id { get; set; }
        public string? ManagerName { get; set; }
        public string? EmailId { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModiifedDate { get; set; }

    }


    public class Status
    {

        public int Id { get; set; }
        public string? Name { get; set; }
    
    }


    public class  RoundType
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }

}
