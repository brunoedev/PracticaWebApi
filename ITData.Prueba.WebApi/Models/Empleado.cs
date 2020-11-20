using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITData.Prueba.WebApi.Models
{
    public class Empleado
    {
        public int id { get; set; }
        public string employee_name { get; set; }
        public decimal employee_salary { get; set; }
        public int employee_age { get; set; }
        public string profile_image { get; set; }
    }
}
