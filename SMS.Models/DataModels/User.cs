using SMS.Models.DataModels.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Models.DataModels
{
    [Table("tbl_Users")]
    public class User : BaseEntity
    {
        [Key]
        [Required]
        public int id { get; set; }
        [Required]
        public string userName { get; set; }
        [Required]
        public string password { get; set; }
        public int userType { get; set; }   
        public int userTypeId { get; set; }
    }

}
