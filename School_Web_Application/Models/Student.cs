using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace School_Web_Application.Models
{
    public class Student
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        [Required]
        public char Gender { get; set; }
    }
}
