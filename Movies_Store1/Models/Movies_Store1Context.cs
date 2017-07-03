using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Movies_Store1.Models
{
    public class Movies_Store1Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Movies_Store1Context() : base("name=Movies_Store1Context")
        {
        }

        public System.Data.Entity.DbSet<Movies_Store1.Models.Movie> Movies { get; set; }
    }
}
