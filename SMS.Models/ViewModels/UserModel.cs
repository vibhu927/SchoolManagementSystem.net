using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SMS.Models.ViewModels
{
    public class UserModel
    {
        [Key]
        [Required]
        public int id { get; set; }
        [Required]
        public string userName { get; set; }
        [Required]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string password { get; set; }
        public int userType { get; set; }
        
        //public string token { get; set; }
        // public int userTypeId { get; set; }
    }
}
