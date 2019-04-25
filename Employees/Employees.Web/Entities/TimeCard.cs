using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Employees.Web.Entities
{
    public class TimeCard
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }

        [Range(0, 24)]
        public int Hours { get; set; }

        public DateTime Day { get; set; }
    }
}
