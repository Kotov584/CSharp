using System;
using System.Collections.Generic; 
using System.Linq;

namespace Application
{
    class View
    {
        public static void NumberOfPatientsPerRoom(List<Room> rooms)
        { 
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{"Id",-10} {"Title",-15} {"Number of patients",-15}");
            Console.ResetColor();
            foreach (var room in rooms)
            {
                Console.WriteLine($"{room.Id,-10} {room.Title,-15} {room.Patients.Count(),-15}");  
            } 
        }
        public static void NumberOfPatients(List<Patient> patients)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{"Total number of patients",-10}");
            Console.ResetColor();
            Console.WriteLine($"{patients.Count(),-10}");
            Console.WriteLine();
        }
        public static void NumberOfDoctors(List<Doctor> doctors)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{"Total number of doctors",-10}");
            Console.ResetColor(); 
            Console.WriteLine($"{doctors.Count(),-10}"); 
            Console.WriteLine();
        }
        public static void Rooms(List<Room> rooms)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{"Id",-10} {"Title",-15}");
            Console.ResetColor();
            foreach (var room in rooms)
            {
                Console.WriteLine($"{room.Id,-10} {room.Title,-15}");

            }
            Console.WriteLine();
        }
        public static void Addresses(List<Address> addresses)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{"Id",-10} {"Name",-15} {"Country",-15} {"Code",-15} {"PostalCode",-15}");
            Console.ResetColor();
            foreach (var address in addresses)
            {
                Console.WriteLine($"{address.Id,-10} {address.Name,-15} {address.Country,-15} {address.Code,-15} {address.PostalCode,-15}");

            }
            Console.WriteLine();
        }
        public static void Patients(List<Patient> patients)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{"Id",-10} {"FirstName",-15} {"LastName",-15} {"Age",-15}");
            Console.ResetColor();
            foreach (var patient in patients)
            {
                Console.WriteLine($"{patient.Id,-10} {patient.FirstName,-15} {patient.LastName,-15} {patient.Age,-15}");

            }
            Console.WriteLine();
        }
        public static void Doctors(List<Doctor> doctors)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{"Id",-10} {"FirstName",-15} {"LastName",-15} {"Age",-15}  {"Salary",-15}");
            Console.ResetColor();
            foreach (var doctor in doctors)
            {
                Console.WriteLine($"{doctor.Id,-10} {doctor.FirstName,-15} {doctor.LastName,-15} {doctor.Age,-15}  {doctor.Salary,-15}");

            }
            Console.WriteLine();
        }
        public static void PatientsPerRoom(List<Room> rooms)
        {
            foreach (var room in rooms)
            {
                Console.WriteLine("-------------------");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"{"Id",-10} {"Title",-15}");
                Console.ResetColor();
                Console.WriteLine($"{room.Id,-10} {room.Title,-15}");
                Console.WriteLine($"{"Patients",-10}");
                foreach (var patient in room.Patients)
                {
                    Console.WriteLine($"{patient.FirstName,-15} {patient.LastName,-15} {patient.Age,-15}");
                }
            }
        } 
        public static void PatientsPerAddress(List<Address> addresses)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{"Country",-15}{"Address",-15}{"PostalCode",-15}{"Code",-15}");
            Console.ResetColor();
            foreach (var address in addresses)
            {
                Console.WriteLine($"{address.Country,-15} {address.Name,-15} {address.PostalCode,-15} {address.Code,-15}");
                Console.WriteLine("Patients");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"{"FirstName",-15}{"LastName",-15}{"Age",-15}");
                Console.ResetColor();
                foreach (var patient in address.Patients)
                {
                    Console.WriteLine($"{patient.FirstName,-15} {patient.LastName,-15} {patient.Age,-15}");
                }
            }
            Console.WriteLine();

        }
        public static void PatientsPerDoctor(List<Doctor> doctors)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{"Doctor",-15}{"Patient",-15} ");
            Console.ResetColor();
            foreach (var doctor in doctors)
            {
                Console.WriteLine($"{doctor.FirstName + " " + doctor.LastName,-15} ");
                foreach (var patient in doctor.Patients)
                {
                    Console.WriteLine($"{"",-15}{patient.FirstName + " " + patient.LastName,-15}");
                }
            }
            Console.WriteLine();

        }
        public static void FilterRoomsByTitleAndNumberOfPatients(List<Room> rooms)
        {
            Console.WriteLine("Search rooms by title and number of patients.\r\nWrite room title:");
            string criteria = Console.ReadLine();
            Console.WriteLine("Write number of patients in room:");
            int second_criteria = Convert.ToInt32(Console.ReadLine());
            var filteredRooms =  rooms.Where(room => room.Title.Contains(criteria)).ToList(); 
            if (filteredRooms.Count == 0)
            {
                Console.WriteLine($"There is no Rooms in the Database with this title '{criteria}' and number of patients '{second_criteria}'");
            }
            else
            {
                foreach (var room in filteredRooms) {
                    int total_patients = room.Patients.Count(); 
                    if (total_patients == second_criteria)
                    {
                        Console.WriteLine("Rooms");
                        Console.WriteLine($"{room.Id,-10} {room.Title,-15} {total_patients,-15}");
                        Console.WriteLine("Patients");
                        View.Patients(room.Patients);
                        break;
                    }
                    else 
                    {
                        Console.WriteLine("There is no room matching second criteria");
                        break;
                    }
                }
            }
        }
        public static void FilterPatientsByAge(List<Patient> patients)
        {
            Console.WriteLine("Search patients by age");
            int criteria = Convert.ToInt32(Console.ReadLine());
            var filteredPatients = patients.Where(x => x.Age > criteria).ToList();
            if (filteredPatients.Count == 0)
            {
                Console.WriteLine($"There is no Patients in the Database with this age '{criteria}'");
            }
            else
            {
                View.Patients(filteredPatients);
            }
        }
        public static void FilterDoctorsByFirstName(List<Doctor> doctors)
        {
            Console.WriteLine("Search doctor by first name");
            string criteria = Console.ReadLine();  
            var filteredDoctors = doctors.Where(x => x.FirstName.Contains(criteria)).ToList(); 
            if(filteredDoctors.Count == 0)
            {
                Console.WriteLine($"There is no Doctor in the Database that his firstname contains these '{criteria}'");
            }
            else
            {
                View.Doctors(filteredDoctors);
            }
        }
    }
}
