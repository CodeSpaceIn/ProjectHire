
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
        public string? PrimarySkill { get; set; }
        public bool Active { get; set; }

    }
}
