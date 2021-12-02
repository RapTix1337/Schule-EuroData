using System;

namespace EuroData.Interfaces
{
    public interface IStaffInterface
    {
        public int id { get; set; }
        public string lastName { get; set; }
        string firstName { get; set; }
        string street { get; set; }
        string zipCode { get; set; }
        string city { get; set; }
        string phone { get; set; }
        string gender { get; set; }
        string hiringDate { get; set; }
        int department { get; set; }
        string car1 { get; set; }
        string car2 { get; set; }
    }
}