using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Models.ViewModels
{
    public class AppSettings
    {
        public string Secret { get; set; }
        public long ExpiryTime { get; set; }
        public int HashIterationCount { get; set; }
        public int ForgotPasswordTokenValidationTime { get; set; }
        public string Issuer { get; set; }
    }
}
