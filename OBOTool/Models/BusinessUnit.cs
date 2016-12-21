using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace OBOTool.Models
{
    public class BusinessUnit
    {
        public int Id { get; set; }
        [DisplayName("Business Unit")]
        public string Name { get; set; }

        public virtual ICollection<WellDetail> WellDetails { get; set; }
    }
}