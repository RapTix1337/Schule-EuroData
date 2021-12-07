using System;
using System.Collections.Generic;
using EuroData.Interfaces;

namespace EuroData.Classes.Entities
{
    public class Project
    {
        public int projectNumber;
        public string title;
        public double contractValue;
        public double paidAmount;
        public DateTime start;
        public DateTime end;
        public bool canceled;
        public List<IStaffInterface> staff;
        public IStaffInterface responsible;
        
    }
}