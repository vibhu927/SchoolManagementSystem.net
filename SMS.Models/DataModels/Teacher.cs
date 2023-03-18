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
    [Table("tbl_Teachers")]
    public class Teacher : BaseEntity
    {
        [Key]
        [Required]
        public int id { get; set; }
        [Required]
        public string userName { get; set; }
        [Required]
        public string password { get; set; }
        [Required]
        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime dob { get; set; }
        public string email { get; set; }
        //public string role { get; set; }
        public string phoneNumber { get; set; }
        public string fathersName { get; set; }
        public string mothersName { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zipcode { get; set; }
        public string country { get; set; }
        public string qualification { get; set; }
        public string designation { get; set; }
    }
}
