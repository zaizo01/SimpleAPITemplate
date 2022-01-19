using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiPractices.Entities
{
    public class Departament
    {
        public Guid Id { get; set; }
        public string DepartamentManager { get; set; }
        public string DepartamentName { get; set; }
        public int QuantityOfEmployees { get; set; }
    }
}
