using System;
using EuroData.Interfaces;

namespace EuroData.Classes.Entities
{
    public class Staff : IStaffInterface
    {
        public int id { get; set; }
        public string lastName { get; set; }
        public string firstName { get; set; }
        public string street { get; set; }
        public string zipCode { get; set; }
        public string city { get; set; }
        public string phone { get; set; }
        public string gender { get; set; }
        public DateTime hiringDate { get; set; }
        public int department { get; set; }
        public string car1 { get; set; }
        public string car2 { get; set; }

        public Staff(int id,string lastName, string firstName, string street, string zipCode, string city, string phone,
            string gender, DateTime hiringDate, int department, string car1, string car2)
        {
            this.id = id;
            this.lastName = lastName;
            this.firstName = firstName;
            this.street = street;
            this.zipCode = zipCode;
            this.city = city;
            this.phone = phone;
            this.gender = gender;
            this.hiringDate = hiringDate;
            this.department = department;
            this.car1 = car1;
            this.car2 = car2;
        }
    }
}