using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiringPortal.Infrastructure
{
    public static class CandidateQueries
    {
       
        public static string AllCandidates => "SELECT d.Id, d.[FirstName], d.[LastName], d.[EmailID], d.PrimarySkill, d.[PhoneNumber], d.[Address], d.[Active] from dbo.Candidate d;";

        public static string CandidateById => "SELECT * FROM [Contact] (NOLOCK) WHERE [ContactId] = @ContactId";

        public static string CreateCandidate =>
            @"Insert into dbo.Candidate (FirstName,LastName,EmailID,PrimarySkill,PhoneNumber,Active) VALUES (@FirstName,@LastName,@EmailID,@PrimarySkill,@PhoneNumber,@Active);";

        public static string UpdateCandidate =>
            @"UPDATE dbo.Candidate SET FirstName = @FirstName, LastName = @LastName, EmailID = @EmailID, Price = @Price, PrimarySkill = @PrimarySkill,PhoneNumber =@PhoneNumber,Address=@Address,Active =@Active,ModifiedBy=@ModifiedBy, ModifiedDate= @ModifiedDate WHERE Id = @Id";

        public static string DeleteCandidate => @"DELETE FROM dbo.Candidates WHERE Id = @Id";
    }


    public static class StoredProc
    {

        public static string getAllCandidatesSkillset => "[dbo].[Sp_GetAllCandidatesSkillSet]";



    }
}
