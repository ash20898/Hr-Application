using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HRApplocationAR.Models
{
    public class Employee
    {
        
        [Required(ErrorMessage ="please input the name")]
        [StringLength(20,MinimumLength =3,ErrorMessage ="Name must be more than 3 char")]
        public string MyName { get; set; }
        [Required(ErrorMessage ="please select the Department")]
        public string Department { get; set; }
        public bool IsActive { get; set; }
        [Required]
        public String JobTitle { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }

    }
}
