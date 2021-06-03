using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Shopping.Common
{
    public class Common
    {
        public Models.ApiResultModel<T> ThrowResult<T>(
     Enum.ApiStatusEnum apiStatus,
     string message, T data)
        {
            var apiResult = new Models.ApiResultModel<T>();

            apiResult.Status = apiStatus;
            apiResult.Message = message;
            apiResult.Data = data;

            return apiResult;
        }

    }
}