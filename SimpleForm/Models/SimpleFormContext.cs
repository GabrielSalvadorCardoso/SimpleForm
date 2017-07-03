using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SimpleForm.Models 
{
    public class SimpleFormContext : DbContext
    {
        public DbSet<Comentario> Comentarios { get; set; }

        public SimpleFormContext()
        {
            DropCreateDatabaseIfModelChanges<SimpleFormContext> initializer = new DropCreateDatabaseIfModelChanges<SimpleFormContext>() ;
            Database.SetInitializer<SimpleFormContext>(initializer);
        }
}
}