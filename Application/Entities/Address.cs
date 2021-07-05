using System.Collections.Generic;

namespace Application
{
    class Address {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public int Code { get; set; }
        public double PostalCode { get; set; }
        public List<Patient> Patients { get; set; } = new List<Patient>();
    }

}
