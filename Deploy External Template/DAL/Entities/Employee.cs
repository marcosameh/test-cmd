using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Deploy_External_Template.DAL.Entities
{
    [Table("Employee")]
    public class Employee
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public String Name { get; set; }

        [RegularExpression("[0-9]{3-5}-[a-zA-Z]{3,50}-[a-zA-Z]{3,50}-[a-zA-Z]{3,50}", ErrorMessage = ("Enter LIKE 12-Streetame-CityName-Countryame"))]
        public string Address { get; set; }
        public bool Active { get; set; }
        public String Email { get; set; }
    
        public int Department_id { get; set; }

        public Department Department { get; set; }

    }
}
