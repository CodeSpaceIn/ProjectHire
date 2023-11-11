
using System;
namespace HiringPortal.Core.Models
{
    public class Candidate
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailID { get; set; }
        public int? PhoneNumber { get; set; }
        public string? Address { get; set; }
        //public string? PrimarySkill { get; set; }
        public bool Active { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set;}

        public List<CandidatePrimarySkills>? PrimarySkills { get; set; }
    }


    public class CandidatePrimarySkills
    {
        public int Id { get; set; }
        public int CandidateID { get; set; }
        public int SkillId { get; set; }
        public string SkillName { get; set; }
        public bool isPrimary { get; set; }

    }

}
