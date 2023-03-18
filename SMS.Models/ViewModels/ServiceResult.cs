using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Models.ViewModels
{
    public class ServiceResult
    {
        public bool Status { get; set; }
        public int StatusCode { get; set; }
        public dynamic ResultData { get; set; }
        public string Message { get; set; }
        public string ResourceType { get; set; }
        public Meta MetaData { get; set; }

    }

    public class Meta
    {
        public int PageNo { get; set; }
        public int PageSize { get; set; }
        public int TotalCount { get; set; }
        public int TotalPages { get; set; }
    }
}
