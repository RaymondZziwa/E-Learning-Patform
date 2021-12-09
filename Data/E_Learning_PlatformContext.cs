using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace E_Learning_Platform.Data
{
    public class E_Learning_PlatformContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public E_Learning_PlatformContext() : base("name=E_Learning_PlatformContext")
        {
        }

        public System.Data.Entity.DbSet<E_Learning_Platform.Models.Student> Students { get; set; }

        public System.Data.Entity.DbSet<E_Learning_Platform.Models.Sclass> Sclasses { get; set; }
    }
}
