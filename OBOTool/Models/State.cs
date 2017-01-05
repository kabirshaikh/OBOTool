using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OBOTool.Models
{
    public class State
    {
        public int Id { get; set; }

        [DisplayName("State")]
        public string Name { get; set; }

    }
}