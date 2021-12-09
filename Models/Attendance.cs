using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace E_Learning_Platform.Models
{
    public class Attendance
    {
        public DateTime DateTime { get; set; }
        [Key]
        public int StudentId { get; set; }
    }
}