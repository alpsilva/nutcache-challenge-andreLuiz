using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NutcachePeopleManagement.Models
{
    public class Person
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public DateTime StartDate { get; set; }
        // Can be: Mobile, Fronted, Backend, null
        public string Team { get; set; }
    }
}
