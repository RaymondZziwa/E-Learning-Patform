using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Learning_Platform.Models
{
    public class Tutor
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public int LastName { get; set; }
        public int Age { get; set; }    
        public string Gender { get; set; }
        public int Contact { get; set; }

    }
}