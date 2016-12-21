using System.ComponentModel;

namespace OBOTool.Models
{
    public class Election
    {
        public int Id { get; set; }
        [DisplayName("Election")]
        public string Name { get; set; }
    }
}