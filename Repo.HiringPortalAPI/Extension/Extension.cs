
using Repo.HiringPortalAPI.Utility;
using System.Runtime.CompilerServices;
using static Dapper.SqlMapper;

namespace Repo.HiringPortalAPI.Extension
{
    public static class Extension
    {

        public static ApiResponse<T> ToResponse<T>(this T entity)
        {
            var apiResponse = new ApiResponse<T>();
            apiResponse.Success = true;
            apiResponse.Result = entity;
            return apiResponse;
        }


        public static ApiResponse<T> ToErrorResponse<T>(this T? entity)
        {
            var apiResponse = new ApiResponse<T>();
            apiResponse.Success = false;
            apiResponse.Message = entity.ToString();
            return apiResponse;

        }

    }
}
