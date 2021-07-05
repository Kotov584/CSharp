using System.Collections.Generic;

namespace Application
{
    class Room {
        public int Id { get; set; }
        public string Title { get; set; } 
        public List<Patient> Patients { get; set; } = new List<Patient>();
    }
}
