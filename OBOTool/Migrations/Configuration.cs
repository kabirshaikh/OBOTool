using System.Collections.Generic;
using OBOTool.Models;

namespace OBOTool.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<OBOTool.Models.OBOModel>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(OBOTool.Models.OBOModel context)
        {
            IEnumerable<BusinessUnit> businessUnits = new List<BusinessUnit>
            {
                new BusinessUnit(),
                new BusinessUnit {Id=1, Name = "Rocky Mountain"},
                new BusinessUnit {Id=2, Name = "Anadarko Basin"}
            };
            context.BusinessUnits.AddRange(businessUnits);

            IEnumerable<Election> elections = new List<Election>
            {
                new Election(),
                new Election {Id=1, Name = "Operated"},
                new Election {Id=2, Name = "OBO - Elect In"}
            };
            context.Elections.AddRange(elections);

            context.WellDetails.AddOrUpdate(
                wd => wd.Id,
                new WellDetail
                {
                    Name = "ARBALEST 66-0607H",
                    ApiNumber = "4900561702",
                    Latitude = 43.560733,
                    Longitude = -105.557064
                });

        }
    }
}
