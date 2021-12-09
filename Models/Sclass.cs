using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Learning_Platform.Models
{
    public class Sclass
    {
        public int Id { get; set; }
        public string ClassName { get; set; }
        public List<Student> Students { get; set; }

    }
}