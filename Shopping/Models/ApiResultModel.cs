using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shopping.Models
{
    public class ApiResultModel<DataT>
    {
        public DataT Data { get; set; }
        public string Message { get; set; }
        public Enum.ApiStatusEnum Status { get; set; }
    }
}