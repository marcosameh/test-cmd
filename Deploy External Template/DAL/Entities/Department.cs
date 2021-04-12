using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Deploy_External_Template.DAL.Entities
{
    [Table("Department")]
    public class Department
    {
        public int id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string code { get; set; }
        public virtual ICollection <Employee> Employee { get; set; }
    }
}
