namespace OBOTool.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class OBOModel : DbContext
    {
        // Your context has been configured to use a 'OBOModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'OBOTool.Models.OBOModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'OBOModel' 
        // connection string in the application configuration file.
        public OBOModel()
            : base("name=OBOModel")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

         public virtual DbSet<WellDetail> WellDetails { get; set; }
         public virtual DbSet<BusinessUnit> BusinessUnits { get; set; }
         public virtual DbSet<Election> Elections { get; set; }
         public virtual DbSet<State> States { get; set; }

    }
}