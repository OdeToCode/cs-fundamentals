using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Employees.Web.Entities
{
    public class Employee 
    {
        [Column("EmployeeID")]
        public int? ID { get; set; }

        [StringLength(255)]
        [Column(TypeName = "varchar(255)")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(300)]
        public string LastName { get; set; }

        public string MiddleName { get; set; }

        public DateTime HireDate { get; set; }

        public IList<TimeCard> TimeCards { get; set; }
    }

}
