using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDatabase db = new MyDatabase();
            string input = "";
            void ShowMenu()
            {
                Console.WriteLine("Choose An Option");
                Console.WriteLine("1 - All Doctors");
                Console.WriteLine("2 - All Addresses");
                Console.WriteLine("3 - All Patients");
                Console.WriteLine("4 - All Rooms");
                Console.WriteLine("5 - All Patients per Room");
                Console.WriteLine("6 - All Patients per Doctor");
                Console.WriteLine("7 - All Patients per Address");
                Console.WriteLine("8 - Filter doctors by first name");
                Console.WriteLine("9 - Filter patients by age");
                Console.WriteLine("10 - Filter rooms by title and number of patients");
                Console.WriteLine("11 - Number of doctors");
                Console.WriteLine("12 - Number of patients");
                Console.WriteLine("13 - Number of patients per room");
                Console.WriteLine("14 - All doctors ascending by first name");
                Console.WriteLine("15 - All addresses descending by country");
                Console.WriteLine("16 - All patients ascending by age");
                Console.WriteLine("17 - All rooms ascending by title");
                Console.WriteLine("0 - Show Menu");
                Console.WriteLine("E - Exit");
            }
            ShowMenu();
            do
            {
                input = Console.ReadLine();
                Console.Clear();
                switch (input)
                {
                    case "0": ShowMenu(); break;
                    case "1": View.Doctors(db.Doctors); break;
                    case "2": View.Addresses(db.Addresses); break;
                    case "3": View.Patients(db.Patients); break;
                    case "4": View.Rooms(db.Rooms);  break;
                    case "5": View.PatientsPerRoom(db.Rooms); break;
                    case "6": View.PatientsPerDoctor(db.Doctors);  break;
                    case "7": View.PatientsPerAddress(db.Addresses);  break;
                    case "8": View.FilterDoctorsByFirstName(db.Doctors); break;
                    case "9": View.FilterPatientsByAge(db.Patients); break;
                    case "10": View.FilterRoomsByTitleAndNumberOfPatients(db.Rooms); break;
                    case "11": View.NumberOfDoctors(db.Doctors); break;
                    case "12": View.NumberOfPatients(db.Patients);  break;
                    case "13": View.NumberOfPatientsPerRoom(db.Rooms); break;
                    case "14": View.Doctors(db.Doctors.OrderBy(x => x.FirstName).ToList());  break;
                    case "15": View.Addresses(db.Addresses.OrderByDescending(x => x.Country).ToList()); break;
                    case "16": View.Patients(db.Patients.OrderBy(x => x.Age).ToList()); break;
                    case "17": View.Rooms(db.Rooms.OrderBy(x => x.Title).ToList()); break;
                    default: Console.WriteLine("Error: Command not found"); break;
                }
            } while (input != "E");
        }
    }
}
