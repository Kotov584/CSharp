using System.Collections.Generic; 

namespace Application
{
    class MyDatabase
    {
        public List<Doctor> Doctors { get; set; } = new List<Doctor>();
        public List<Patient> Patients { get; set; } = new List<Patient>();
        public List<Address> Addresses { get; set; } = new List<Address>();
        public List<Room> Rooms { get; set; } = new List<Room>();

        public MyDatabase()
        {

            #region Seeding Doctors

            Doctor d1 = new Doctor()
            {
                Id = 1,
                FirstName = "Lakis",
                LastName = "Papas",
                Age = 33,
                Salary = 32000
            };
            Doctor d2 = new Doctor()
            {
                Id = 2,
                FirstName = "Maria",
                LastName = "Pepa",
                Age = 35,
                Salary = 36000
            };
            Doctor d3 = new Doctor()
            {
                Id = 3,
                FirstName = "Fanis",
                LastName = "Papias",
                Age = 38,
                Salary = 39000
            };

            #endregion

            #region Seeding Patients

            Patient p1 = new Patient()
            {
                Id = 1,
                FirstName = "Vladyslav",
                LastName = "Kotov",
                Age = 18
            };


            #endregion

            #region Seeding Addresses
            Address a1 = new Address()
            {
                Id = 1,
                Name = "25 Martiou Street",
                Country = "Greece",
                Code = 24224,
                PostalCode = 15124
            };
            Address a2 = new Address()
            {
                Id = 2,
                Name = "28 Oktovriou Street",
                Country = "Greece",
                Code = 4224,
                PostalCode = 15124
            };
            Address a3 = new Address()
            {
                Id = 3,
                Name = "Achilleiou Street",
                Country = "Greece",
                Code = 1341,
                PostalCode = 15124
            };
            Address a4 = new Address()
            {
                Id = 4,
                Name = "Aristomenous Street	",
                Country = "Greece",
                Code = 23425,
                PostalCode = 12351
            };
            Address a5 = new Address()
            {
                Id = 5,
                Name = "Charakti Alevizou Tassou Street	",
                Country = "Greece",
                Code = 85785,
                PostalCode = 12351
            };
            Address a6 = new Address()
            {
                Id = 6,
                Name = "Dimitsanas Street",
                Country = "Greece",
                Code = 3424,
                PostalCode = 12351
            };
            Address a7 = new Address()
            {
                Id = 7,
                Name = "28 Oktovriou Avenue	",
                Country = "Greece",
                Code = 3523,
                PostalCode = 18451
            };
            Address a8 = new Address()
            {
                Id = 8,
                Name = "Aidiniou Street	",
                Country = "Greece",
                Code = 2453,
                PostalCode = 18453
            };
            Address a9 = new Address()
            {
                Id = 9,
                Name = "Ikoniou Street",
                Country = "Greece",
                Code = 9546,
                PostalCode = 18450
            };
            Address a10 = new Address()
            {
                Id = 10,
                Name = "Laodikeias Street",
                Country = "Greece",
                Code = 5355,
                PostalCode = 18451
            };
            #endregion

            #region Seeding Rooms
            Room r1 = new Room()
            {
                Id = 1,
                Title = "Room - #1"
            };
            Room r2 = new Room()
            {
                Id = 2,
                Title = "Room - #2"
            };
            Room r3 = new Room()
            {
                Id = 3,
                Title = "Room - #3"
            };
            Room r4 = new Room()
            {
                Id = 4,
                Title = "Room - #4"
            };
            Room r5 = new Room()
            {
                Id = 5,
                Title = "Room - #5"
            };
            Room r6= new Room()
            {
                Id = 6,
                Title = "Room - #6"
            };
            Room r7 = new Room()
            {
                Id = 7,
                Title = "Room - #7"
            };
            Room r8 = new Room()
            {
                Id = 8,
                Title = "Room - #8"
            };
            Room r9 = new Room()
            {
                Id = 9,
                Title = "Room - #9"
            };
            Room r10 = new Room()
            {
                Id = 10,
                Title = "Room - #10"
            };
            Room r11 = new Room()
            {
                Id = 11,
                Title = "Room - #11"
            };
            Room r12 = new Room()
            {
                Id = 12,
                Title = "Room - #12"
            };
            Room r13 = new Room()
            {
                Id = 13,
                Title = "Room - #13"
            };
            Room r14 = new Room()
            {
                Id = 14,
                Title = "Room - #14"
            };
            Room r15 = new Room()
            {
                Id = 15,
                Title = "Room - #15"
            };
            #endregion

            #region Relate Doctors to Patients

            d1.Patients.Add(p1);

            p1.Doctor = d1;

            r1.Patients.Add(p1);
            a1.Patients.Add(p1);

            #endregion

            #region Relate Rooms To Patients 

            #endregion

            #region Populate Tables (Doctors, Patients, Rooms, Addresses)
            List<Doctor> tempDoctors = new List<Doctor>() { d1, d2, d3 };
            Doctors.AddRange(tempDoctors);

            List<Patient> tempPatients = new List<Patient>() { p1 };
            Patients.AddRange(tempPatients);

            List<Address> tempAddresses = new List<Address>() { a1, a2, a3, a4, a5, a6, a7, a8, a9, a10 };
            Addresses.AddRange(tempAddresses);
             
            List<Room> tempRooms = new List<Room>() { r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12, r13, r14, r15 };
            Rooms.AddRange(tempRooms);
            #endregion



        }

    }
}
